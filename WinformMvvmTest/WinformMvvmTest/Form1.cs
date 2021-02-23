using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformMvvmTest
{
    public partial class Form1 : Form
    {
        TestClass test1 = new TestClass();
        TestClass test2 = new TestClass();
        List<LiveCharts.WinForms.CartesianChart> charts = new List<LiveCharts.WinForms.CartesianChart>();
        int testnum = 0;
        public Form1()
        {
            InitializeComponent();
            InitControllers();
        }

        /// <summary>
        /// 控件逻辑的初始化
        /// </summary>
        private void InitControllers()
        {
            textBox1.DataBindings.Add("Text",test1, "QRCode",false,DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text",test1,"QRCode",false,DataSourceUpdateMode.OnPropertyChanged);

            charts.Add(cartesianChart1);
            charts.Add(cartesianChart2);
            charts.Add(cartesianChart3);
            charts.Add(cartesianChart4);

            for (int i = 0; i < 4; i++)
            {
                if (i<2)
                {
                    charts[i].DataBindings.Add("AxisX", test1, "XAxis", false, DataSourceUpdateMode.OnPropertyChanged);
                    charts[i].DataBindings.Add("Series", test1, "Series", false, DataSourceUpdateMode.OnPropertyChanged);
                }
                else
                {
                    charts[i].DataBindings.Add("AxisX", test2, "XAxis", false, DataSourceUpdateMode.OnPropertyChanged);
                    charts[i].DataBindings.Add("Series", test2, "Series", false, DataSourceUpdateMode.OnPropertyChanged);
                }
                
                charts[i].AxisX.Clear();
                charts[i].AxisX.Add(new LiveCharts.Wpf.Axis());
                charts[i].AxisX[0].Labels = new List<string>();
            }

            //cartesianChart1.DataBindings.Add("AxisX",test1, "XAxis",false,DataSourceUpdateMode.OnPropertyChanged);
            //cartesianChart1.DataBindings.Add("Series",test1,"Series",false,DataSourceUpdateMode.OnPropertyChanged);
            //cartesianChart1.AxisX.Clear();
            //cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis());
            //cartesianChart1.AxisX[0].Labels = new List<string>();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            test1.QRCode = new Random().Next(0,100).ToString();
            label1.Text = "变量值" + test1.QRCode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = new Random().Next(0, 100).ToString();
            label1.Text = "变量值" + test1.QRCode;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            test1.QRCode = new Random().Next(0,100).ToString();
            label1.Text = "变量值" + test1.QRCode;
            test1.XAxis[0].Labels.Add(testnum++.ToString());
            test1.Series[0].Values.Add((double)testnum);

            test2.XAxis[0].Labels.Add(testnum.ToString());
            test2.Series[0].Values.Add((double)testnum);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            test1.XAxis[0].Labels.Add(testnum++.ToString());
            test1.Series[0].Values.Add((double)testnum);
        }
    }

    class TestClass:INotifyPropertyChanged
    {
        string _QRCode;
        LiveCharts.Wpf.AxesCollection _XAxis;
        LiveCharts.SeriesCollection _series;

        public LiveCharts.Wpf.AxesCollection XAxis {
            get { return _XAxis; }
            set {
                _XAxis = value;
                NotifyPropertyChanged("XAxis");
            } }
        public LiveCharts.SeriesCollection Series {
            get { return _series; }
            set 
            {
                _series = value;
                NotifyPropertyChanged("Series");
            }
        }

        public TestClass()
        {
            _XAxis = new LiveCharts.Wpf.AxesCollection();
            _XAxis.Add(new LiveCharts.Wpf.Axis());
            _XAxis[0].Labels = new List<string>();
            _series = new LiveCharts.SeriesCollection();
            _series.Add(new LiveCharts.Wpf.LineSeries() { Values = new LiveCharts.ChartValues<double>()});

        }
        public string QRCode {
            get{ return _QRCode; }
            set
            {
                _QRCode = value;
                NotifyPropertyChanged("QRCode");
            } }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string ProName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(ProName));
            }
        }
    }
    
}
