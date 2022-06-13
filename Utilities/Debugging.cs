using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworDemo.Utilities
{
    public class Debugging
    {
        public String GetClassName<T>(T classname)
        {
            return classname.GetType().Name;
        }

        public String GetMethodname<T>(T methodname)
        {
            return methodname.GetType().Name;
        }
    }
}
