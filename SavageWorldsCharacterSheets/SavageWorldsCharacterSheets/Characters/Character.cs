using SavageWorldsCharacterSheets.Edges;
using SavageWorldsCharacterSheets.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SavageWorldsCharacterSheets.Characters
{
    /// <summary>
    /// Represents a character in Savage worlds
    /// </summary>
    [Serializable]
    public class Character
    {
        public string Name { get; set; }
        public int Charisma { get; set; }
        public int Pace { get; set; }
        public int Parry { get; set; }
        public int Toughness { get; set; }
        public Value Agility { get; set; }
        public Value Smarts { get; set; }
        public Value Strength { get; set; }
        public Value Spirit { get; set; }
        public Value Vigor { get; set; }
        public Dictionary<Skill, Value> Skills { get; set; }
        public int Wounds { get; set; }
        public List<Edge> Edges { get; set; }
        public List<Hindrance> Hindrances { get; set; }

        public Character(string name)
        {
            this.Name = name;
            this.Pace = 6;
        }

        /**
        TODO
        Equipment
        Powers
        Hindrances

        Later:
        Injuries
        **/

        public override string ToString()
        {
            StringBuilder retval = new StringBuilder("");
            retval.AppendLine("Name:" + Name);
            retval.AppendLine("Charisma:" + Charisma.ToString());
            retval.AppendLine("Pace:" + Pace.ToString());
            retval.AppendLine("Parry:" + Parry.ToString());
            retval.AppendLine("Toughness:" + Toughness.ToString());
            retval.AppendLine("Agility:" + Agility.ToString());
            retval.AppendLine("Smarts:" + Smarts.ToString());
            retval.AppendLine("Strength:" + Strength.ToString());
            retval.AppendLine("Spirit:" + Spirit.ToString());
            retval.AppendLine("Vigor:" + Vigor.ToString());
            return retval.ToString();
        }

    }
}