using System.IO;
using Newtonsoft.Json.Linq;


namespace airtech_test
{
    class ReadJsonFile
    {
        //parse json file
        public JObject ReadJson(string filePath)
        {
            var jsonFile = File.ReadAllText(filePath);
            var parsedFile = JObject.Parse(jsonFile);
            return parsedFile;
        }
    }
}
