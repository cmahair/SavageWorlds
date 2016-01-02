using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavageWorldsCharacterSheets.Tools
{
    [Serializable]
    public class Skill
    {
        public string Name { get; set; }
        public Attribute GoverningAttribute { get; set; }
    }
}