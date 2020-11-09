using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMonitorDisp.Helper
{
    public static class ArrayHelper
    {
        public static T[] SubArray<T>(this T[] data,int index, int length,int destinationIndex)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, destinationIndex, length);
            return result;
        }

    }
}
