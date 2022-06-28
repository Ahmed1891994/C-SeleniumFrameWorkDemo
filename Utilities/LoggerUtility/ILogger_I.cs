using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworDemo.Utilities.LoggerUtility.Logger
{
    public interface ILogger_I
    {
        void Warn(string text);
        void Info(string text);
        void Error(string text);
    }
}
