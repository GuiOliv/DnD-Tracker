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
        public static string CampaignName { get; private set; }

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

            string fileName1 = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CampaignName), CampaignName + "_msn.json");
            string jsonString1 = JsonConvert.SerializeObject(Msn.ListofMissions, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace
            });

            File.WriteAllText(fileName1, jsonString1);
        }

        public void Deserialize(string nameCampaign)
        {
            var path = File.ReadAllText(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nameCampaign), nameCampaign + "_chr.json"));
            Chr.ListOfPlayers = JsonConvert.DeserializeObject<List<Chr>>(path);

            var path1 = File.ReadAllText(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nameCampaign), nameCampaign + "_msn.json"));
            Msn.ListofMissions = JsonConvert.DeserializeObject<List<Msn>>(path1);
        }
    }
}
