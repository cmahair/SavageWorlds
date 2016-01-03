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

        public static void SaveCharacter(Character character)
        {
            string CharacterFile = HttpContext.Current.Server.MapPath("~/App_Data/Characters/");
            string fileName = CharacterFile + character.Name;
            using (FileStream stream = File.OpenWrite(fileName))
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(character.ToString());
                writer.Close();
            }
        }
    }
}