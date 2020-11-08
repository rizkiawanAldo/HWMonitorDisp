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
using HWMonitorDisp.Constant;
using System.IO.Ports;
using System.Threading;

namespace HWMonitorDisp
{
    public partial class Form1 : Form
    {
        Computer c = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true
        };

        private DataTable _datatable = new DataTable();
        private SerialPort port = new SerialPort();
        private arduinoService _serviceArd = new arduinoService();
        private hardwareService _serviceHardware = new hardwareService();
        private arduinoResponse _selected = new arduinoResponse();
        




        public Form1()
        {
            InitializeComponent();
            getArdunio();
            
            
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

            cpuLoadVal.Text = " : " + data.CPULoad;
            cpuTempVal.Text = " : " + data.CPUTemp;
            gpuLoadVal.Text = " : " + data.GPULoad;
            gpuTempVal.Text = " : " + data.GPUTemp;
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

        }
    }
}
