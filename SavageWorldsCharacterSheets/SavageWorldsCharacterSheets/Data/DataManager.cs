using SavageWorldsCharacterSheets.Characters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SavageWorldsCharacterSheets.Data
{
    public class DataManager
    {
        const string CharacterFile = "Data/Characters/";

        public static void SaveCharacter(Character character)
        {
            string fileName = CharacterFile + character.Name;
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, character);
            }
        }
    }
}