using FrameworDemo.Utilities.LoggerUtility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrameworDemo.Utilities
{
    public class Properties
    {
        private Dictionary<String, String> list;
        private String filename;
        private readonly Logger logger = new();
        public Properties(String file)
        {
            Reload(file);
        }

        public String Get(String field, String defValue)
        {
            String value = Get(field) ?? defValue;
            logger.Info("value of field : " + field + "is : " + value);
            return value ;
        }
        public String Get(String field)
        {
            return (list.ContainsKey(field)) ? (list[field]) : (null);
        }

        public void Set(String field, Object value)
        {
            if (!list.ContainsKey(field))
                list.Add(field, value.ToString());
            else
                list[field] = value.ToString();
        }

        public void Save()
        {
            Save(this.filename);
        }

        public void Save(String filename)
        {
            String path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/Resources/" + filename + ".properties";
            this.filename = path;

            if (!System.IO.File.Exists(filename))
                System.IO.File.Create(filename);

            System.IO.StreamWriter file = new(filename);

            foreach (String prop in list.Keys.ToArray())
                if (!String.IsNullOrWhiteSpace(list[prop]))
                    file.WriteLine(prop + "=" + list[prop]);

            file.Close();
        }

        public void Reload()
        {
            Reload(this.filename);
        }

        public void Reload(String filename)
        {
            String path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/Resources/"+ filename +".properties";
            this.filename = path;
            logger.Info("get path of properties file : " + path);
            list = new Dictionary<String, String>();

            if (System.IO.File.Exists(filename))
            {
                LoadFromFile(path);
            }
            else
            {
                System.IO.File.Create(filename);
            }
        }

        private void LoadFromFile(String file)
        {
            foreach (String line in System.IO.File.ReadAllLines(file))
            {
                if ((!String.IsNullOrEmpty(line)) &&
                    (!line.StartsWith(";")) &&
                    (!line.StartsWith("#")) &&
                    (!line.StartsWith("'")) &&
                    (line.Contains('=')))
                {
                    int index = line.IndexOf('=');
                    String key = line.Substring(0, index).Trim();
                    String value = line.Substring(index + 1).Trim();

                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }

                    try
                    {
                        //ignore dublicates
                        list.Add(key, value);
                    }
                    catch { }
                }
            }
        }
    }
}
