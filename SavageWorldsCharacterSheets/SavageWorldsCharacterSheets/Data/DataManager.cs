using SavageWorldsCharacterSheets.Characters;
using System.IO;
using System.Web;

namespace SavageWorldsCharacterSheets.Data
{
    public class DataManager
    {

        const string CHARACTERFILE = "~/App_Data/Characters/";

        public static void SaveCharacter(Character character)
        {
            string fileName = HttpContext.Current.Server.MapPath(CHARACTERFILE + character.Name);
            using (FileStream stream = File.OpenWrite(fileName))
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(character.ToString());
                writer.Close();
            }
        }

        public static Character LoadCharacter(string name)
        {
            string fileName = HttpContext.Current.Server.MapPath(CHARACTERFILE + name);
            string text = File.ReadAllText(fileName);
            return new Character(text);
        }

        public static string[] Characters()
        {
            string[] retval = Directory.GetFiles(HttpContext.Current.Server.MapPath(CHARACTERFILE));
            for (int i = 0; i < retval.Length; i++)
            {
                retval[i] = Path.GetFileName(retval[i]);
            }
            return retval;
        }
    }
}