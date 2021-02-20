using LiveCharts;
using LiveCharts.Wpf;
using System.Diagnostics;

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 160);
            this.button2.TabIndex = 10;
            this.button2.Text = "一\r\n\r\n\r\n号\r\n\r\n\r\n穴";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 160);
            this.button3.TabIndex = 11;
            this.button3.Text = "一\r\n\r\n\r\n号\r\n\r\n\r\n穴";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 160);
            this.button4.TabIndex = 12;
            this.button4.Text = "一\r\n\r\n\r\n号\r\n\r\n\r\n穴";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 574);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        public void InitialzeChart(int num)
        {
            foreach (int item in dicChart.Keys)
            {
                this.Controls.Remove(dicChart[item]);
            }
            dicChart.Clear();
            dicWatch.Clear();

            int width = this.Size.Width-20; //留下20的空白地
            for (int i = 0; i < 3; i++)
            {
                for (int n = 0; n < num; n++)
                {
                    int average = (width - 50) / num; //扣除前面标题部分后算平均
                    int index = i * num + (n + 1); //1-3*num 当前是第几个，从1开始
                    LiveCharts.WinForms.CartesianChart chart = new LiveCharts.WinForms.CartesianChart();
                    chart.Location = new System.Drawing.Point(50+n*average, 70+i*(160+10));
                    chart.Name = "chart"+index;
                    chart.Size = new System.Drawing.Size(average-10, 160);
                    chart.Text = "仪器图"+index;
                    chart.BackColor = System.Drawing.Color.LightGray;

                    //实例化一条折线图
                    LineSeries mylineseries = new LineSeries();
                    //设置折线的标题
                    mylineseries.Title = index+"号仪器";
                    //折线图直线形式
                    mylineseries.LineSmoothness = 0;
                    //折线图的无点样式
                    mylineseries.PointGeometry = null;

                    //添加折线图的数据
                    mylineseries.Values = new ChartValues<double>(temp);
                    chart.Series.Add(mylineseries);
                    chart.DisableAnimations = false;
                    

                    Controls.Add(chart);
                    dicChart.Add(index, chart);
                    dicWatch.Add(index, new Stopwatch());
                    
                }



            }

            


        }

        #endregion
        public string num { get; set; }
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

