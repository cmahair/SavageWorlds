using System;

namespace SavageWorldsCharacterSheets.Tools
{
    [Serializable]
    public class Skill
    {
        public string Name { get; set; }
        public Attribute GoverningAttribute { get; set; }
    }
}