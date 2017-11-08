using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitSample1
{
    /// <summary>
    /// ＧＵＩ画面です。
    /// </summary>
    public partial class 画面 : Form
    {
        本体 logic=new 本体();

        public 画面()
        {
            InitializeComponent();            
            logic.通知 += (sender, e) => 途中経過の情報表示.Text = $"値1: {e.Item1}/ 値2: {e.Item2}";// タプル値の受け取りと文字列挿入記法
        }

        /// <summary>
        /// 一秒ごとのタイマーで起動される処理です。
        /// </summary>
        void 秒タイマー_Tick(object sender, EventArgs e)
        {
            時刻表示.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// 重い処理ボタンが押されたときの処理です。
        /// </summary>
        async void 重い処理開始ボタン_Click(object sender, EventArgs e)
        {
            var (処理数, 結果)=await logic.重い処理Async(); // タプル戻り値の一括代入
            MessageBox.Show($"{処理数} 回、処理した結果は {結果}。"); // 文字列挿入記法
        }
    }
}
