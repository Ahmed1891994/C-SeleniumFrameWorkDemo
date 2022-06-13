using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworDemo.Utilities
{
    public interface ILogger_I
    {
        void Warn(String text);
        void Info(String text);
        void Error(String text);
    }
}
