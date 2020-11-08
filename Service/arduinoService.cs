using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using HWMonitorDisp.Response;

namespace HWMonitorDisp.Service
{
    class arduinoService
    {
        public arduinoResponse AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);


            arduinoResponse result = new arduinoResponse();

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    List<detectedCom> data = new List<detectedCom>();

                    detectedCom _com = new detectedCom();
                    _com.DeviceID = deviceId;
                    _com.Desc = desc;

                    data.Add(_com);
                    result.comList = data;

                    if (desc.Contains("Arduino"))
                    {
                        result.autoSelected = item["DeviceID"].ToString();
                        return result;
                    }
                }
                return result;
            }
            catch (ManagementException e)
            {
                throw e;
                /* Do Nothing */
            }


        }
    }
}
