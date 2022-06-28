using FrameworDemo.Utilities.LoggerUtility;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;


namespace FrameworDemo.Utilities.DataReaderUtility
{
    public class JsonReader : IDataDriven
    {
        private readonly Logger logger;
        public JsonReader()
        {
            logger = new();
        }
        public string[] DataReader(string Jsonfilename, string key, bool single = true)
        {
            string[] result = null;
            string myJsonString = File.ReadAllText(Jsonfilename);
            logger.Info("Read all data from Json File and save it in string variable successfully");

            var JsonObject = JToken.Parse(myJsonString);
            logger.Info("Parse Json data from String successfully");

            if (single)
            {
                result[0] = JsonObject.SelectToken(key).Value<string>();
                logger.Info("Select single data with token : " + key + " with value : " + result[0]);
            }
            else
            {
                result = JsonObject.SelectTokens(key).Values<string>().ToList().ToArray();
                logger.Info("Select Multiple data with token : " + key);
            }
            return result;
        }

        public void DataSetter(string filename, string key, string value)
        {
            throw new NotImplementedException();
        }
    }
}
