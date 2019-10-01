using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace InStat
{
    public static class Data
    {
        internal static readonly Dictionary<string, List<string>> Bio = InitBio();

        public static Dictionary<string, List<string>> InitBio()
        {
            JObject jobject = null;
            var filePath = AppDomain.CurrentDomain.BaseDirectory + "data.json";
            var text = File.ReadAllText(filePath);
            jobject = JObject.Parse(text);
            var allBio = new Dictionary<string, List<string>>();

            foreach (var d in jobject)
            {
                var value = d.Value.ToString().Split(',').ToList();
                allBio.Add(d.Key, value);
            }

            return allBio;
        }
    }
}
