using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitSample1
{
    /// <summary>
    /// ビジネスロジック本体です。
    /// </summary>
    class 本体
    {
        /// <summary>
        /// ２つの整数がタプルで通知されます。
        /// </summary>
        public event EventHandler<(int,int)> 通知; // タプル戻り値

        /// <summary>
        /// 長い時間がかかる裏方処理です。途中で通知イベントを発生させます。
        /// </summary>
        /// <returns>処理数と、重い処理をした結果を文字列で返します。</returns>
        public async Task<(int, string)> 重い処理Async()
        {
            var 処理数 = 5;
            var 合計 = 0;
            foreach(var i in Enumerable.Range(1, 処理数))
            {
                await Task.Delay(i*1000); // Task クラスを使用した新しい待たせ方
                合計 += i;
                通知?.Invoke(this, (i, 合計)); // Null 条件演算子とタプル指定

            }
            return (処理数, "合計："+合計);
        }
    }
}
