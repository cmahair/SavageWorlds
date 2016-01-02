using SavageWorldsCharacterSheets.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavageWorldsCharacterSheets.Characters
{
    /// <summary>
    /// Represents a character in Savage worlds
    /// </summary>
    public class Character
    {
        public string Name { get; set; }
        public int Charisma { get; set; }
        public int Pace { get; set; }
        public int Parry { get; set; }
        public int Toughness { get; set; }
        public Tools.Attribute Agility { get; set; }
        public Tools.Attribute Smarts { get; set; }
        public Tools.Attribute Strength { get; set; }
        public Tools.Attribute Spirit { get; set; }
        public Tools.Attribute Vigor { get; set; }
        public List<Skill> Skills { get; set; }
        public int Wounds { get; set; }

        /**
        TODO
        Equipment
        Powers
        Hindrances
        Edges

        Later:
        Injuries
        **/
    }
}