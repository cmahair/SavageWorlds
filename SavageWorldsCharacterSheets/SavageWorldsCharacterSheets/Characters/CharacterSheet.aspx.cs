using SavageWorldsCharacterSheets.Tools;
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
            BuildTable();
        }

        [WebMethod]
        public static void NewCharacter()
        {
            character = new Character("Enter Name");
            
        }

        [WebMethod]
        public static int BuildCharacter(string name)
        {
            character = new Character(name);
            return character.Pace;
        }

        private void BuildTable()
        {
            ddlagility.DataSource = Enum.GetNames(typeof(Dice));
            ddlagility.DataBind();
            ddlsmarts.DataSource = Enum.GetNames(typeof(Dice));
            ddlsmarts.DataBind();
            ddlspirit.DataSource = Enum.GetNames(typeof(Dice));
            ddlspirit.DataBind();
            ddlstrength.DataSource = Enum.GetNames(typeof(Dice));
            ddlstrength.DataBind();
            ddlvigor.DataSource = Enum.GetNames(typeof(Dice));
            ddlvigor.DataBind();
        }
    }
}