using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace w20210218
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 图形键值对
        /// </summary>
        public static Dictionary<int, LiveCharts.WinForms.CartesianChart> dicChart = new Dictionary<int, LiveCharts.WinForms.CartesianChart>();
        /// <summary>
        /// 数据键值对
        /// </summary>
        public Dictionary<int, Queue<PointXY>> dicData = new Dictionary<int, Queue<PointXY>>();
        /// <summary>
        /// 计时器
        /// </summary>
        public static Dictionary<int, Stopwatch> dicWatch = new Dictionary<int, Stopwatch>();

        /// <summary>
        /// 图标总数
        /// </summary>
        public int number
        {
            get { return 3 * int.Parse(num); }
        }


        private double[] temp = { };

        public Form1()
        {
            InitializeComponent();
            InitialzeChart(3);
            num = 3.ToString();
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
            for (int i = 1; i <= number; i++)
            {
                dicData[i].Enqueue(pointXY);
                ShowChart(dicChart[i], dicData[i]);
            }






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
            for (int i = 1; i <= number; i++)
            {
                dicData.Add(i, new Queue<PointXY>());
            }
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
