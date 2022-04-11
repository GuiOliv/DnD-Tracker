using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Tracker.Components
{
    public class Msn
    {
        public static List<Msn> ListofMissions { get; set; } = new List<Msn>();
        public string Name { get; set; }
        public static List<Msn> ListofCompletedMissions
        {
            get
            {
                return ListofMissions.Where(w => w.Completed).Select(s => s as Msn).ToList();
            }
        }
        public bool Completed { get; set; } = false;
        public List<Chr> ListofPLayersinMissions { get; set; }
        public int XP { get; set; }
        public int Money { get; set; }
        public string Description { get; set; }

        public Msn(string name, List<Chr> chrs, int xp, int money, string description = null)
        {
            Name = name;
            ListofPLayersinMissions = chrs;
            XP = xp;
            Money = money;
            Description = description;
            ListofMissions.Add(this);
        }

        public void XPManager(string Operation, int value)
        {
            switch (Operation)
            {
                case "+":
                    XP += value;
                    break;
                case "-":
                    XP -= value;
                    break;
            }
        }

        public void MoneyManager(string Operation, int value)
        {
            switch (Operation)
            {
                case "+":
                    Money += value;
                    break;
                case "-":
                    Money -= value;
                    break;
            }
        }
    }
}
