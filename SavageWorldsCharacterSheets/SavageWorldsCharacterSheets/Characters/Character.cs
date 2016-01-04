using SavageWorldsCharacterSheets.Edges;
using SavageWorldsCharacterSheets.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

        public Character() { }

        /// <summary>
        /// Instantiate a character from the file data
        /// </summary>
        /// <param name="text"></param>
        public Character(string text)
        {
            using (StringReader reader = new StringReader(text))
            {
                string line;
                string[] stuff;
                while ((line = reader.ReadLine()) != null)
                {
                    stuff = line.Split(':');
                    switch (stuff[0])
                    {
                        case "Name":
                            this.Name = stuff[1];
                            break;
                        case "Charisma":
                            this.Charisma = int.Parse(stuff[1]);
                            break;
                        case "Pace":
                            this.Pace = int.Parse(stuff[1]);
                            break;
                        case "Parry":
                            this.Parry = int.Parse(stuff[1]);
                            break;
                        case "Toughness":
                            this.Toughness = int.Parse(stuff[1]);
                            break;
                        case "Agility":
                            this.Agility = new Value(stuff[1]);
                            break;
                        case "Smarts":
                            this.Smarts = new Value(stuff[1]);
                            break;
                        case "Strength":
                            this.Strength = new Value(stuff[1]);
                            break;
                        case "Spirit":
                            this.Spirit = new Value(stuff[1]);
                            break;
                        case "Vigor":
                            this.Vigor = new Value(stuff[1]);
                            break;
                    }
                }
            }
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