using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMonitorDisp.Response
{
    public class arduinoResponse
    {
        public List<detectedCom> comList { get; set; }
        public string autoSelected { get; set; }
        public string selectedDesc { get; set; }

    }
    public class detectedCom
    {
        public string DeviceID { get; set; }
        public string Desc { get; set; }

    }
}
