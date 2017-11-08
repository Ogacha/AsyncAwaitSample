namespace AsyncAwaitSample1
{
    partial class 画面
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.重い処理開始ボタン = new System.Windows.Forms.Button();
            this.秒タイマー = new System.Windows.Forms.Timer(this.components);
            this.時刻表示 = new System.Windows.Forms.Label();
            this.途中経過の情報表示 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 重い処理開始ボタン
            // 
            this.重い処理開始ボタン.Location = new System.Drawing.Point(30, 38);
            this.重い処理開始ボタン.Name = "重い処理開始ボタン";
            this.重い処理開始ボタン.Size = new System.Drawing.Size(118, 23);
            this.重い処理開始ボタン.TabIndex = 0;
            this.重い処理開始ボタン.Text = "重い処理開始";
            this.重い処理開始ボタン.UseVisualStyleBackColor = true;
            this.重い処理開始ボタン.Click += new System.EventHandler(this.重い処理開始ボタン_Click);
            // 
            // 秒タイマー
            // 
            this.秒タイマー.Enabled = true;
            this.秒タイマー.Interval = 1000;
            this.秒タイマー.Tick += new System.EventHandler(this.秒タイマー_Tick);
            // 
            // 時刻表示
            // 
            this.時刻表示.AutoSize = true;
            this.時刻表示.Location = new System.Drawing.Point(28, 150);
            this.時刻表示.Name = "時刻表示";
            this.時刻表示.Size = new System.Drawing.Size(62, 12);
            this.時刻表示.TabIndex = 1;
            this.時刻表示.Text = "時刻を表示";
            // 
            // 途中経過の情報表示
            // 
            this.途中経過の情報表示.AutoSize = true;
            this.途中経過の情報表示.Location = new System.Drawing.Point(30, 96);
            this.途中経過の情報表示.Name = "途中経過の情報表示";
            this.途中経過の情報表示.Size = new System.Drawing.Size(86, 12);
            this.途中経過の情報表示.TabIndex = 2;
            this.途中経過の情報表示.Text = "途中経過を表示";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.途中経過の情報表示);
            this.Controls.Add(this.時刻表示);
            this.Controls.Add(this.重い処理開始ボタン);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 重い処理開始ボタン;
        private System.Windows.Forms.Timer 秒タイマー;
        private System.Windows.Forms.Label 時刻表示;
        private System.Windows.Forms.Label 途中経過の情報表示;
    }
}

