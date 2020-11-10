using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using HWMonitorDisp.Response;
using HWMonitorDisp.Service;
using HWMonitorDisp.Helper;
using HWMonitorDisp.Constant;
using System.IO.Ports;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Drawing.Configuration;

namespace HWMonitorDisp
{
    public partial class Form1 : Form
    {
        Computer c = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true,
            RAMEnabled = true
        };

        private SerialPort port = new SerialPort();
        private arduinoService _serviceArd = new arduinoService();
        private hardwareService _serviceHardware = new hardwareService();
        private arduinoResponse _selected = new arduinoResponse();
        private StringFormating _formats = new StringFormating();

        private int _defaultInterval = 1000;
        hardwareResponse _data = new hardwareResponse();

        Stopwatch CPULoadTime = new Stopwatch();
        Stopwatch CPUTempTime = new Stopwatch();

       // private int [] cpuLoadArray = new int[1000];

        public Form1()
        {
            InitializeComponent();
            getArdunio();
            
           
           // initChart();
            timer1.Interval = _defaultInterval;
            intervaText.Text = _defaultInterval.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readWriteData();
            #region unused graph
            //if (cpuLoad.Checked)
            //{
            //    int Y = Convert.ToInt32(float.Parse(_data.CPULoad));
            //    chart1.Series["CPULOAD"].Points.AddXY(CPULoadTime.ElapsedMilliseconds, Y);          
            //    if (CPULoadTime.ElapsedMilliseconds > 10000)
            //    {
            //        chart1.Series["CPULOAD"].Points.RemoveAt(0);
            //        chart1.ResetAutoValues();
            //    }               
            //}
            //if (cpuTemp.Checked)
            //{
            //    int Y = Convert.ToInt32(float.Parse(_data.CPUTemp));
            //    chart1.Series["CPUTEMP"].Points.AddXY(CPULoadTime.ElapsedMilliseconds, Y);
            //    if (CPUTempTime.ElapsedMilliseconds > 10000)
            //    {
            //        chart1.Series["CPUTEMP"].Points.RemoveAt(0);
            //        chart1.ResetAutoValues();
            //    }
            //}
            //debugLabel.Text = CPULoadTime.ElapsedMilliseconds.ToString();
            #endregion

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            c.Open();
        }
        private void initChart()
        {

            chart1.Series.RemoveAt(0);
            chart1.ChartAreas.RemoveAt(0);

            chart1.ChartAreas.Add("CPU");
            chart1.ChartAreas["CPU"].AxisY.Maximum = 100;
            chart1.ChartAreas["CPU"].AxisY.Minimum = 0;
            chart1.ChartAreas["CPU"].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas["CPU"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["CPU"].Visible = true;
            

        }

        private void readWriteData()
        {
            

            _data = _serviceHardware.GetSystemreading(c);
           
            cpuLoadVal.Text = " : "+ _formats.TwoDecimal(_formats.NoZero(_data.CPULoad)) +  "  %";
            cpuTempVal.Text = " : " + _formats.TwoDecimal(_formats.NoZero(_data.CPUTemp)) + "  c";
            gpuLoadVal.Text = " : " + _formats.TwoDecimal(_formats.NoZero(_data.GPULoad)) + "  %";
            gpuTempVal.Text = " : " + _formats.TwoDecimal(_formats.NoZero(_data.GPUTemp)) + "  c";
            ramUsedVal.Text = " : " + _formats.TwoDecimal(_data.RAMUsed) + "MB";
        }
        
        private void scanButton_Click(object sender, EventArgs e)
        {
            Status.Visible = false;
            getArdunio();
            if (comListText.Items.Count == 0)
            {
                Status.Text = "No port detected !";
                Status.ForeColor = Color.Firebrick;
                Status.Visible = true;
            }
        }
        private void getArdunio()
        {
            comListText.Items.Clear();
           //arduinoResponse result = new arduinoResponse();
            _selected = _serviceArd.AutodetectArduinoPort();

            if (_selected.comList != null)
            {
                comListText.Items.Add(_selected.comList.Select(a => a.DeviceID).FirstOrDefault());
                if (_selected.autoSelected != null)
                {
                    comListText.SelectedItem = _selected.autoSelected;
                    portDesc.Text = "Description :" + _selected.comList.Where(a => a.DeviceID == _selected.autoSelected).Select(a => a.Desc).FirstOrDefault(); ;
                    return;
                }


                comListText.Items.Add(_selected.comList.Select(a => a.DeviceID).FirstOrDefault());
                comListText.SelectedItem = _selected.autoSelected;
                portDesc.Text = "Description :" + _selected.comList.Where(a => a.DeviceID == _selected.autoSelected).Select(a => a.Desc).FirstOrDefault(); ;
                return;
            }
            else
            {

                comListText.ResetText();
                portDesc.Text = "Description :";
            }
            return;

        }

        private void comListText_SelectedIndexChanged(object sender, EventArgs e)
        {
            portDesc.Text = "Description :" + _selected.comList.Where(a => a.DeviceID == comListText.SelectedItem.ToString()).Select(a => a.Desc).FirstOrDefault(); ;
        }

        private void intervaText_TextChanged(object sender, EventArgs e)
        {
           // debugLabel.Text = timer1.Interval.ToString();
            valInter.Visible = false;
            valInter.Text = "";

            if (!string.IsNullOrWhiteSpace(intervaText.Text))
            {
                try
                {
                    int interva = Convert.ToInt32(intervaText.Text);
                    if (interva >= 200 && interva <= 2000)
                    {
                        timer1.Interval = interva;
                        debugLabel.Text = timer1.Interval.ToString();
                        return;
                    }
                    else
                    {
                        valInter.Text = "Masukan Angka diantara 200 - 2000 ms";
                        valInter.Visible = true;
                        timer1.Interval = _defaultInterval;
                        debugLabel.Text = timer1.Interval.ToString();
                        return;
                    }

                }
                catch (Exception)
                {
                    valInter.Text = "Masukan Angka valid";
                    valInter.Visible = true;
                    return;
                }

            }
            else
            {
                valInter.Text = "Masukan Angka";
                valInter.Visible = true;
                timer1.Interval = _defaultInterval;
                debugLabel.Text = timer1.Interval.ToString();              
            }

        }

        private void cpuLoad_CheckedChanged(object sender, EventArgs e)
        {
            //if (cpuLoad.Checked)
            //{             
            //    chart1.Series.Add("CPULOAD");
            //    chart1.Series["CPULOAD"].ChartArea = "CPU";
            //    chart1.Series["CPULOAD"].LegendText = "CPU Load";
            //    chart1.Series["CPULOAD"].ChartType = SeriesChartType.Line;
            //    chart1.Series["CPULOAD"].IsValueShownAsLabel=false;
            //    CPULoadTime.Start();
            //}
            //else
            //{
            //    chart1.Series.Remove(chart1.Series["CPULOAD"]);
            //    CPULoadTime.Stop();
            //    CPULoadTime.Reset();            
            //}
        }

        private void cpuTemp_CheckedChanged(object sender, EventArgs e)
        {
            //if (cpuTemp.Checked)
            //{
            //    chart1.Series.Add("CPUTEMP");
            //    chart1.Series["CPUTEMP"].ChartArea = "CPU";
            //    chart1.Series["CPUTEMP"].LegendText = "CPU Temp";
            //    chart1.Series["CPUTEMP"].ChartType = SeriesChartType.Line;
            //    chart1.Series["CPUTEMP"].IsValueShownAsLabel = false;
            //    CPUTempTime.Start();
            //}
            //else
            //{
            //    chart1.Series.Remove(chart1.Series["CPUTEMP"]);
            //    CPUTempTime.Stop();
            //    CPUTempTime.Reset();
            //}

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (comListText.SelectedItem != null)
            {
                try
                {
                    _serviceArd.ConnectArduino(comListText.SelectedItem);
                    Status.Text = "Connected !";
                    Status.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Status.Text = "Masukan Port !";
                Status.ForeColor = Color.Firebrick;
                Status.Visible = true;
            }
            

        }

        private void DisconnButton_Click(object sender, EventArgs e)
        {
            try
            {
                _serviceArd.DisconnectArduino();
                Status.Text = "Disconnected !";
                Status.ForeColor = Color.Firebrick;
                Status.Visible = true;
            }
            catch (Exception)
            {
                Status.Text = "no opened port :(";
                Status.ForeColor = Color.Firebrick;
                Status.Visible = true;
                return;
            }
        }
    }
}
