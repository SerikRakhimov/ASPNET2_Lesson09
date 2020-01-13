using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Script.Serialization;

namespace Repository.Interfases.Release
{
    public class JsonRepository : IRepository
    {
        public IEnumerable<MOCK_DATA> List()
        {
            string jsonReponseString = File.ReadAllText(HostingEnvironment.MapPath(@"/App_Data/MOCK_DATA.json"));
            IEnumerable<MOCK_DATA> list = JsonConvert.DeserializeObject<IEnumerable<MOCK_DATA>>(jsonReponseString);
            return list;
        }
    }
}