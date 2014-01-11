using System;
using System.Diagnostics;

namespace ControllerFactoryDI.Tools
{
    public class LogFile : ILog
    {
        public void Log(string str)
        {
            Debug.Write(str);
        }
    }
}