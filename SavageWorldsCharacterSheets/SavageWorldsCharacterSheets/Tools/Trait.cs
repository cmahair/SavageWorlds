using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavageWorldsCharacterSheets.Tools
{
    /// <summary>
    /// Representation of any attribute or skill
    /// </summary>
    public abstract class Trait
    {
        public string Name { get; set; }
        public Dice Value { get; set; }
        public int Modifier { get; set; }
    }
}