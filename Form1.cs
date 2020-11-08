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

            cpuLoad.Text = Labling.CPULOAD + data.CPULoad;
            cpuTemp.Text = Labling.CPUTEMP + data.CPUTemp;
            gpuLoad.Text = Labling.GPULOAD + data.GPULoad;
            gpuTemp.Text = Labling.CPUTEMP + data.GPUTemp;
        }
        
        private void scanButton_Click(object sender, EventArgs e)
        {

        }
        private void getArdunio()
        {
            comListText.Items.Clear();
            arduinoResponse result = new arduinoResponse();
            result = _serviceArd.AutodetectArduinoPort();
            if (result.comList != null)
            {
                comListText.Items.Add(result.comList.Select(a => a.DeviceID).FirstOrDefault());
                if (result.autoSelected != null)
                {
                    comListText.SelectedItem = result.autoSelected;
                    portDesc.Text = "Description :" + result.comList.Where(a => a.DeviceID == result.autoSelected).Select(a => a.Desc).FirstOrDefault(); ;
                    return;
                }


                comListText.Items.Add(result.comList.Select(a => a.DeviceID).FirstOrDefault());
                comListText.SelectedItem = result.autoSelected;
                portDesc.Text = "Description :" + result.comList.Where(a => a.DeviceID == result.autoSelected).Select(a => a.Desc).FirstOrDefault(); ;
                return;
            }
            else
            {

                comListText.ResetText();
                portDesc.Text = "Description :";
            }
            return;

        }

      
    }
}
