using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace w20210218
{
    public partial class Form1 : Form
    {
        public Dictionary<int, LiveCharts.WinForms.CartesianChart> dicChart = new Dictionary<int, LiveCharts.WinForms.CartesianChart>();
        public Dictionary<int, Queue<PointXY>> dicData = new Dictionary<int, Queue<PointXY>>();
        private double[] temp = { };

        public Form1()
        {
            InitializeComponent();

            //实例化一条折线图
            LineSeries mylineseries = new LineSeries();
            //设置折线的标题
            mylineseries.Title = "Temp";
            //折线图直线形式
            mylineseries.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries.PointGeometry = null;
            
            //添加折线图的数据
            mylineseries.Values = new ChartValues<double>(temp);
            this.cartesianChart1.Series.Add(mylineseries);
            this.cartesianChart1.DisableAnimations = false;


            //实例化一条折线图
            LineSeries mylineseries2 = new LineSeries();
            //设置折线的标题
            mylineseries2.Title = "Temp";
            //折线图直线形式
            mylineseries2.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries2.PointGeometry = null;
            //添加折线图的数据
            mylineseries2.Values = new ChartValues<double>(temp);
            this.cartesianChart2.Series.Add(mylineseries2);
            this.cartesianChart2.DisableAnimations = false;

            //实例化一条折线图
            LineSeries mylineseries3 = new LineSeries();
            //设置折线的标题
            mylineseries3.Title = "Temp";
            //折线图直线形式
            mylineseries3.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries3.PointGeometry = null;
            //添加折线图的数据
            mylineseries3.Values = new ChartValues<double>(temp);
            this.cartesianChart3.Series.Add(mylineseries3);
            this.cartesianChart3.DisableAnimations = false;

            //实例化一条折线图
            LineSeries mylineseries4 = new LineSeries();
            //设置折线的标题
            mylineseries4.Title = "Temp";
            //折线图直线形式
            mylineseries4.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries4.PointGeometry = null;
            //添加折线图的数据
            mylineseries4.Values = new ChartValues<double>(temp);
            this.cartesianChart4.Series.Add(mylineseries4);
            this.cartesianChart4.DisableAnimations = false;

            //实例化一条折线图
            LineSeries mylineseries5 = new LineSeries();
            //设置折线的标题
            mylineseries5.Title = "Temp";
            //折线图直线形式
            mylineseries5.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries5.PointGeometry = null;
            //添加折线图的数据
            mylineseries5.Values = new ChartValues<double>(temp);
            this.cartesianChart5.Series.Add(mylineseries5);
            this.cartesianChart5.DisableAnimations = false;

            //实例化一条折线图
            LineSeries mylineseries6 = new LineSeries();
            //设置折线的标题
            mylineseries6.Title = "Temp";
            //折线图直线形式
            mylineseries6.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries6.PointGeometry = null;
            //添加折线图的数据
            mylineseries6.Values = new ChartValues<double>(temp);
            this.cartesianChart6.Series.Add(mylineseries6);
            this.cartesianChart6.DisableAnimations = false;

            //实例化一条折线图
            LineSeries mylineseries7 = new LineSeries();
            //设置折线的标题
            mylineseries7.Title = "Temp";
            //折线图直线形式
            mylineseries7.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries7.PointGeometry = null;
            //添加折线图的数据
            mylineseries7.Values = new ChartValues<double>(temp);
            this.cartesianChart7.Series.Add(mylineseries7);
            this.cartesianChart7.DisableAnimations = false;

            //实例化一条折线图
            LineSeries mylineseries8 = new LineSeries();
            //设置折线的标题
            mylineseries8.Title = "Temp";
            //折线图直线形式
            mylineseries8.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries8.PointGeometry = null;
            //添加折线图的数据
            mylineseries8.Values = new ChartValues<double>(temp);
            this.cartesianChart8.Series.Add(mylineseries8);
            this.cartesianChart8.DisableAnimations = false;

            //实例化一条折线图
            LineSeries mylineseries9 = new LineSeries();
            //设置折线的标题
            mylineseries9.Title = "X轴";
            //折线图直线形式
            mylineseries9.LineSmoothness = 0;
            //折线图的无点样式
            mylineseries9.PointGeometry = null;
            //添加折线图的数据
            mylineseries9.Values = new ChartValues<double>(temp);
            this.cartesianChart9.Series.Add(mylineseries9);
            this.cartesianChart9.DisableAnimations = false;



        }

        double x1 = 1;
        double n = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            PointXY pointXY = new PointXY();
            pointXY.X = x1;
            pointXY.Y = n;
            x1 = x1 + 1;
            n = n + 0.2;
            Console.WriteLine(x1 + "=" + n);
            dicData[1].Enqueue(pointXY);

            dicData[2].Enqueue(pointXY);
            dicData[3].Enqueue(pointXY);
            dicData[4].Enqueue(pointXY);
            dicData[5].Enqueue(pointXY);
            dicData[6].Enqueue(pointXY);
            dicData[7].Enqueue(pointXY);
            dicData[8].Enqueue(pointXY);
            dicData[9].Enqueue(pointXY);

            ShowChart(dicChart[1], dicData[1]);
            ShowChart(dicChart[2], dicData[2]);
            ShowChart(dicChart[3], dicData[3]);
            ShowChart(dicChart[4], dicData[4]);
            ShowChart(dicChart[5], dicData[5]);
            ShowChart(dicChart[6], dicData[6]);
            ShowChart(dicChart[7], dicData[7]);
            ShowChart(dicChart[8], dicData[8]);
            ShowChart(dicChart[9], dicData[9]);

        }

        /// <summary>
        /// 刷新chart
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="que"></param>
        public void ShowChart(LiveCharts.WinForms.CartesianChart chart, Queue<PointXY> que)
        {
            List<string> list = new List<string>();

            chart.Series[0].Values.Clear();
           


            for (int i = 0; i < que.Count; i++)
            {

                PointXY point = que.ElementAt(i);


                LiveCharts.Wpf.Axis ax = new LiveCharts.Wpf.Axis();
                Console.WriteLine(point.X + "=" + point.Y);
                
                list.Add(point.X.ToString());
                ax.Labels = list;





                chart.AxisX.Clear();
                chart.AxisX.Add(ax);
                chart.AxisX[0].Separator.Step = 1;

                chart.AxisX[0].Separator.IsEnabled = false;

                // chart.AxisX[0].Labels.Add(point.X.ToString());
                chart.Series[0].Values.Add(point.Y);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dicChart.Add(1, cartesianChart1);
            dicChart.Add(2, cartesianChart2);
            dicChart.Add(3, cartesianChart3);
            dicChart.Add(4, cartesianChart4);
            dicChart.Add(5, cartesianChart5);
            dicChart.Add(6, cartesianChart6);
            dicChart.Add(7, cartesianChart7);
            dicChart.Add(8, cartesianChart8);
            dicChart.Add(9, cartesianChart9);

            dicData.Add(1, new Queue<PointXY>());
            dicData.Add(2, new Queue<PointXY>());
            dicData.Add(3, new Queue<PointXY>());
            dicData.Add(4, new Queue<PointXY>());
            dicData.Add(5, new Queue<PointXY>());
            dicData.Add(6, new Queue<PointXY>());
            dicData.Add(7, new Queue<PointXY>());
            dicData.Add(8, new Queue<PointXY>());
            dicData.Add(9, new Queue<PointXY>());

            //for (int i = 0; i < 20; i++)
            //{
            //    PointXY pointXY = new PointXY();
            //    pointXY.X = i;
            //    pointXY.Y = i * 0.2 + 0.5;

            //    Console.WriteLine(pointXY.X + "=" + pointXY.Y);
            //    dicData[1].Enqueue(pointXY);
            //}

            //ShowChart(dicChart[1], dicData[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //dicData[1].Clear();
            //for (int i = 0; i < 20; i++)
            //{
            //    PointXY pointXY = new PointXY();
            //    pointXY.X = i;
            //    pointXY.Y = i * 0.2 + 0.5;


            //    dicData[1].Enqueue(pointXY);
            //}


            //ShowChart(dicChart[1], dicData[1]);
            timer1.Stop();
        }
    }

    public class PointXY
    {
        public double X;


        public double Y;


    }
}
