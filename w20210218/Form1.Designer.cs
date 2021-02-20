namespace w20210218
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart7 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart5 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart4 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart9 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart8 = new LiveCharts.WinForms.CartesianChart();
            this.cartesianChart6 = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(28, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(632, 12);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart3.TabIndex = 2;
            this.cartesianChart3.Text = "cartesianChart3";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(319, 12);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart2.TabIndex = 1;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // cartesianChart7
            // 
            this.cartesianChart7.Location = new System.Drawing.Point(632, 353);
            this.cartesianChart7.Name = "cartesianChart7";
            this.cartesianChart7.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart7.TabIndex = 8;
            this.cartesianChart7.Text = "cartesianChart7";
            // 
            // cartesianChart5
            // 
            this.cartesianChart5.Location = new System.Drawing.Point(319, 176);
            this.cartesianChart5.Name = "cartesianChart5";
            this.cartesianChart5.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart5.TabIndex = 4;
            this.cartesianChart5.Text = "cartesianChart5";
            // 
            // cartesianChart4
            // 
            this.cartesianChart4.Location = new System.Drawing.Point(37, 176);
            this.cartesianChart4.Name = "cartesianChart4";
            this.cartesianChart4.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart4.TabIndex = 3;
            this.cartesianChart4.Text = "cartesianChart4";
            // 
            // cartesianChart9
            // 
            this.cartesianChart9.Location = new System.Drawing.Point(37, 353);
            this.cartesianChart9.Name = "cartesianChart9";
            this.cartesianChart9.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart9.TabIndex = 6;
            this.cartesianChart9.Text = "cartesianChart9";
            // 
            // cartesianChart8
            // 
            this.cartesianChart8.Location = new System.Drawing.Point(319, 353);
            this.cartesianChart8.Name = "cartesianChart8";
            this.cartesianChart8.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart8.TabIndex = 7;
            this.cartesianChart8.Text = "cartesianChart8";
            // 
            // cartesianChart6
            // 
            this.cartesianChart6.Location = new System.Drawing.Point(632, 176);
            this.cartesianChart6.Name = "cartesianChart6";
            this.cartesianChart6.Size = new System.Drawing.Size(261, 158);
            this.cartesianChart6.TabIndex = 5;
            this.cartesianChart6.Text = "cartesianChart6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartesianChart7);
            this.Controls.Add(this.cartesianChart8);
            this.Controls.Add(this.cartesianChart9);
            this.Controls.Add(this.cartesianChart6);
            this.Controls.Add(this.cartesianChart5);
            this.Controls.Add(this.cartesianChart4);
            this.Controls.Add(this.cartesianChart3);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Timer timer1;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private LiveCharts.WinForms.CartesianChart cartesianChart7;
        private LiveCharts.WinForms.CartesianChart cartesianChart5;
        private LiveCharts.WinForms.CartesianChart cartesianChart4;
        private LiveCharts.WinForms.CartesianChart cartesianChart9;
        private LiveCharts.WinForms.CartesianChart cartesianChart8;
        private LiveCharts.WinForms.CartesianChart cartesianChart6;
        private System.Windows.Forms.Button button1;
    }
}

