using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Tracker.Components
{
    public class Campaign
    {
        public static string CampaignName { get; set; }

        public Campaign(string campaignName)
        {
            CampaignName = campaignName;
        }
        public void Serialize()
        {
            string fileName = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CampaignName), CampaignName + "_chr.json");
            string jsonString = JsonConvert.SerializeObject(Chr.ListOfPlayers, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            File.WriteAllText(fileName, jsonString);


        }

        public void Deserialize(string nameCampaign)
        {
            var path = File.ReadAllText(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nameCampaign), nameCampaign + "_chr.json"));
            Chr.ListOfPlayers = JsonConvert.DeserializeObject<List<Chr>>(path);
        }
    }
}
