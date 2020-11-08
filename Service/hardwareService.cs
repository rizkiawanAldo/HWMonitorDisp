using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWMonitorDisp.Response;

namespace HWMonitorDisp.Service
{
    public class hardwareService
    {
        public hardwareResponse GetSystemreading(Computer c)
        {
         
            hardwareResponse result = new hardwareResponse();
            foreach (var hardwadre in c.Hardware)
            {
                #region GRAPHIC CARDS GET VALUE
                if (hardwadre.HardwareType == HardwareType.GpuAti)
                {
                    hardwadre.Update();
                    foreach (var _sensor in hardwadre.Sensors)
                    {
                        if (_sensor.SensorType == SensorType.Temperature)
                            result.GPUTemp = _sensor.Value.GetValueOrDefault().ToString();
                        if (_sensor.SensorType == SensorType.Load)
                            result.GPULoad = _sensor.Value.GetValueOrDefault().ToString();
                    }
                }
                if (hardwadre.HardwareType == HardwareType.GpuNvidia)
                {
                    hardwadre.Update();
                    foreach (var _sensor in hardwadre.Sensors)
                    {
                        if (_sensor.SensorType == SensorType.Temperature)
                            result.GPUTemp = _sensor.Value.GetValueOrDefault().ToString();
                        if (_sensor.SensorType == SensorType.Load)
                            result.GPULoad = _sensor.Value.GetValueOrDefault().ToString();
                    }
                }
                #endregion

                #region CPU GET VALUE
                if (hardwadre.HardwareType == HardwareType.CPU)
                {
                    hardwadre.Update();
                    
                    foreach (var _sensor in hardwadre.Sensors)
                    {
                       
                        if (_sensor.SensorType == SensorType.Temperature)
                         result.CPUTemp = _sensor.Value.GetValueOrDefault().ToString();                        
                        
                        if (_sensor.SensorType == SensorType.Load && _sensor.Name == "CPU Total")
                         result.CPULoad = _sensor.Value.GetValueOrDefault().ToString();                                            
                       
                    }

                }
                #endregion
                if (hardwadre.HardwareType == HardwareType.RAM)
                {
                    hardwadre.Update();

                    foreach (var _sensor in hardwadre.Sensors)
                    {

                        if (_sensor.Name == "Used Memory")
                            result.RAMUsed = _sensor.Value.GetValueOrDefault().ToString();
                 

                    }

                }

            }

            return result;        
        }
    }
}
