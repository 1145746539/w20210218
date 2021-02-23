using LiveCharts.WinForms;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace w20210218
{
    public partial class TestForm : Form
    {
        /// <summary>
        /// 用于存储图表Panel的列表  用于隐藏和显示面板
        /// </summary>
        List<Panel> ListChartPanels = new List<Panel>();
        /// <summary>
        /// 用于存储界面的所有图表。
        /// </summary>
        List<List<CartesianChart>> ListChart = new List<List<CartesianChart>>();
        public TestForm ChartForm;
        Timer UpdataTimer = new Timer();
        public TestForm()
        {
            ChartForm = this;
            ChartForm.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            CreateChart(3);
            CheckForIllegalCrossThreadCalls = false;
            InitControllers();
        }


        /// <summary>
        /// 其他控件的初始化
        /// </summary>
        private void InitControllers()
        {
        
        }
        /// <summary>
        /// 在主界面生成图表
        /// </summary>
        /// <param name="num">生成图表的行数  每行三个图表</param>
        private void CreateChart(int num)
        {

            #region 生成顶部菜单按钮
            Panel Panel_MainMenu = new Panel
            {
                Dock = DockStyle.Top,
                Height = 50,
                BackColor = Color.Gray
            };

            Button btn_Min = new Button
            {
                Dock = DockStyle.Right,
                Text = "最小化",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Yellow
            };
            btn_Min.FlatAppearance.BorderSize = 0;
            btn_Min.Click += new EventHandler((sender, e) =>
            {
                this.WindowState = FormWindowState.Minimized;
            });
            Panel_MainMenu.Controls.Add(btn_Min);
            Panel whiteblock = new Panel();
            whiteblock.Dock = DockStyle.Top;
            whiteblock.Height = 20;

            #endregion

            for (int i = 0; i < 3; i++)
            {
                Button button = new Button
                {
                    Text = "打开穴位" + (3 - i) + "图表",
                    FlatStyle = FlatStyle.Flat,
                    Width = 300,
                    Name = "btn_chart" + (3 - i),
                    BackColor = Color.FromArgb(170 + i * 10, 170 + i * 10, 170 + i * 10),
                    Dock = DockStyle.Left
                };
                button.FlatAppearance.BorderSize = 0;
                #region 菜单图表按钮事件
                button.Click += new EventHandler((sender, e) =>
                {
                    Button btn = sender as Button;

                });
                #endregion

                Panel_MainMenu.Controls.Add(button);


                Panel panel_chart = new Panel
                {
                    Dock = DockStyle.Top,
                    Name = "ChartPanel" + i,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.FromArgb(153, 153, 153),
                    Height = (ChartForm.Height) / 3
                };
                ListChartPanels.Add(panel_chart);
                this.Controls.Add(panel_chart);
                List<CartesianChart> AListChart = new List<CartesianChart>();
                for (int j = 0; j < 3; j++)
                {
                    CartesianChart chart = new CartesianChart();
                    chart.Dock = DockStyle.Left;
                    chart.Name = "chart_"+i+"_"+(3 - j).ToString();
                    chart.Width = ChartForm.Width / 3 - 10;
                    
                    //chart.Height = ListChartPanels[i].Height-10;
                    AListChart.Add(chart);
                    ListChartPanels[i].Controls.Add(chart);
                }
                ListChart.Add(AListChart);
            }

            
            //添加顺序会影响布局  请不要修改控件的添加顺序。
            this.Controls.Add(whiteblock);
            this.Controls.Add(Panel_MainMenu);

        }

        
    }



    

}
