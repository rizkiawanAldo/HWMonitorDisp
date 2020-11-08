using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMonitorDisp.Response
{
    public class hardwareResponse
    {
        public string CPULoad { get; set; }
        public string CPUTemp { get; set; }
        public string GPULoad { get; set; }
        public string GPUTemp { get; set; }
        public string RAMUsed { get; set; }
    }
}
