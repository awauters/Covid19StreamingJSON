using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace Covid19StreamingJsonOef
{
    public class Importer
    {
        public List<Mortality> GetMortality()
        {
            List<Mortality> jsonList;
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://epistat.sciensano.be/Data/Covid19BE_Mort.json");
                jsonList = JsonConvert.DeserializeObject<List<Mortality>>(json);
            }
            return jsonList;
        }

        public List<Mortality> ReadMortalityFromXmlFile(string fileName)
        {
            List<Mortality> mortalityList = null;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Mortality>));
            using (StreamReader reader = new StreamReader(fileName))
            {
                mortalityList = (List<Mortality>)serializer.Deserialize(reader);
            }
            return mortalityList;
        }
        public List<Mortality> ReadMortalityFromJsonFile(string fileName)
        {
            List<Mortality> objects;

            using (StreamReader file = File.OpenText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                objects = (List<Mortality>)serializer.Deserialize(file, typeof(List<Mortality>));
            }
            return objects;
        }
    }
  
    }

