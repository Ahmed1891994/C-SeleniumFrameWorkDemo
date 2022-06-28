using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworDemo.Utilities.DebuggingUtility
{
    public class Debugging
    {
        public string GetClassName<T>(T classname)
        {
            return classname.GetType().Name;
        }

        public string GetMethodname<T>(T methodname)
        {
            return methodname.GetType().Name;
        }
    }
}
