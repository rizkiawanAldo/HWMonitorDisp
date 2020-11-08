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

        private DataTable _datatable = new DataTable();
        private SerialPort port = new SerialPort();
        private arduinoService _serviceArd = new arduinoService();
        private hardwareService _serviceHardware = new hardwareService();
        private arduinoResponse _selected = new arduinoResponse();
        private StringFormating _formats = new StringFormating();
        private int _defaultInterval = 500;
        




        public Form1()
        {
            InitializeComponent();
            getArdunio();
            timer1.Interval = _defaultInterval;
            intervaText.Text = _defaultInterval.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readWriteData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            c.Open();
        }

        private void readWriteData()
        {
            hardwareResponse data = new hardwareResponse();

            data = _serviceHardware.GetSystemreading(c);
           
            cpuLoadVal.Text = " : "+ _formats.TwoDecimal(_formats.NoZero(data.CPULoad)) +  "  %";
            cpuTempVal.Text = " : " + _formats.TwoDecimal(_formats.NoZero(data.CPUTemp)) + "  c";
            gpuLoadVal.Text = " : " + _formats.TwoDecimal(_formats.NoZero(data.GPULoad)) + "  %";
            gpuTempVal.Text = " : " + _formats.TwoDecimal(_formats.NoZero(data.GPUTemp)) + "  c";
            ramUsedVal.Text = " : " + _formats.TwoDecimal( data.RAMUsed) + "MB";
        }
        
        private void scanButton_Click(object sender, EventArgs e)
        {
            getArdunio();
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
            debugLabel.Text = timer1.Interval.ToString();
            valInterNum.Visible = false;
            valInterLim.Visible = false;
            if (!string.IsNullOrWhiteSpace(intervaText.Text))
            {
                foreach (char c in intervaText.Text)
                {
                    if (c < '0' || c > '9')
                    {
                        valInterNum.Visible = true;
                        timer1.Interval = _defaultInterval;
                        break;
                    }
                    else
                    {
                        int interva = Convert.ToInt32(intervaText.Text);
                        if (interva >= 200 && interva <= 2000)
                        {
                            timer1.Interval = interva;
                            debugLabel.Text = timer1.Interval.ToString();
                            break;
                        }
                        else
                        {
                            valInterLim.Visible = true;
                            timer1.Interval = _defaultInterval;
                            debugLabel.Text = timer1.Interval.ToString();
                            break;
                        }


                    }
                }
            }
            else
            {
                valInterNum.Visible = true;
                timer1.Interval = _defaultInterval;
                debugLabel.Text = timer1.Interval.ToString();
               
            }

        }
    }
}
