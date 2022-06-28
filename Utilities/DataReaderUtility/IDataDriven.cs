using System;
using System.Runtime.InteropServices;


namespace FrameworDemo.Utilities.DataReaderUtility
{
    public interface IDataDriven
    {
        public String[] DataReader(String filename,String key, bool flag);
        public void DataSetter(String filename, String key, String value);
    }
}
