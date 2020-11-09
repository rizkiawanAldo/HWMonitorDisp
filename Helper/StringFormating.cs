using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMonitorDisp.Helper
{
     class StringFormating
    {
        public string NoZero(string input)
        {
            string result = "";
            if (!String.IsNullOrWhiteSpace(input))
            result = input.Length == 1 ? input +".00" : input;

            return result;
        }
        public string TwoDecimal(string input)
        {
            string result = "";
            input = input + "0000000";
            result = input.Substring(0, input.IndexOf('.') + 3);

            return result;
        }

    }
}
