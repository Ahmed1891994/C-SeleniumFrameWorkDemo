using FrameworDemo.Utilities.LoggerUtility;
using System;


namespace FrameworDemo.Utilities.DataReaderUtility
{
    public class CSVReader : IDataDriven
    {
        private readonly Logger logger;
        public CSVReader()
        {
            logger = new();
        }
        public string[] DataReader(string filename, string key, bool flag)
        {
            throw new NotImplementedException();
        }

        public void DataSetter(string filename, string key, string value)
        {
            throw new NotImplementedException();
        }
    }
}
