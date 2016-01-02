using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SavageWorldsCharacterSheets.Characters
{
    public partial class CharacterSheet : System.Web.UI.Page
    {
        private static Character character;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static int BuildCharacter(string name)
        {
            character = new Character(name);
            return character.Pace;
        }
    }
}