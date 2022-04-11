using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Tracker.Components
{
    public class Chr
    {
        #region Variables
        public static List<Chr> ListOfPlayers { get; set; } = new List<Chr>();
        public string NameCharacter { get; set; }
        public string NamePlayer { get; set; }
        public Classes Class { get; set; }
        public Races Race { get; set; }
        public int money { get; set; }
        public int xp { get; set; }
        public List<string> ListofSpells { get; set; } = new List<string>();
        public string CharacterSheetFileName { get; set; }
        #endregion

        public Chr(string NameChr, string NamePl, Classes cl, Races rc, List<string>Listofspells, string charactersheet)
        {
            NameCharacter = NameChr;
            NamePlayer = NamePl;
            Class = cl;
            Race = rc;
            ListofSpells = Listofspells;
            CharacterSheetFileName = charactersheet;
            ListOfPlayers.Add(this);
        }

        public void XPManager(string Operation, int value)
        {
            switch (Operation)
            {
                case "+":
                    xp += value;
                    break;
                case "-":
                    xp -= value;
                    break;
            }
        }

        public void MoneyManager(string Operation, int value)
        {
            switch (Operation)
            {
                case "+":
                    money += value;
                    break;
                case "-":
                    money -= value;
                    break;
            }
        }
    }

    public enum Classes
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard,
        Artificer
    }
    public enum Races
    {
        Dragonbord,
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        Halfling,
        HalfOrc,
        Human,
        Tiefling,
        Leonin,
        Satyr
    }
}
