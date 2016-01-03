using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavageWorldsCharacterSheets.Tools
{
    /// <summary>
    /// Contains the die and modifier for any trait
    /// </summary>
    [Serializable]
    public class Value
    {
        public Dice DieType { get; set; }
        public int Modifier { get; set; }

        public override string ToString()
        {
            return DieType.ToString() + "," + Modifier;
        }

        public Value(string data)
        {
            string[] stuff = data.Split(',');
            DieType = (Dice) Enum.Parse(typeof(Dice), stuff[0], true);
            Modifier = int.Parse(stuff[1]);
        }

    }
}