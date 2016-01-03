using SavageWorldsCharacterSheets.Data;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BuildTable();
            }
        }

        [WebMethod]
        public static Character NewCharacter()
        {
            Character character = new Character("Enter Name");
            CharacterSheet page = HttpContext.Current.Handler as CharacterSheet;
            page.ViewState["character"] = character;
            return character;
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

        protected void bsave_Click(object sender, EventArgs e)
        {
            Character character = makeCharacterFromPage();
            DataManager.SaveCharacter(character);
        }

        private Character makeCharacterFromPage()
        {
            Character character = new Character(tbname.Text);
            character.Agility = new Value(ddlagility.SelectedValue + "," + getModifier(tbagility.Text));
            character.Smarts = new Value(ddlsmarts.SelectedValue + "," + getModifier(tbsmarts.Text));
            character.Strength = new Value(ddlstrength.SelectedValue + "," + getModifier(tbstrength.Text));
            character.Spirit = new Value(ddlspirit.SelectedValue + "," + getModifier(tbspirit.Text));
            character.Vigor = new Value(ddlvigor.SelectedValue + "," + getModifier(tbvigor.Text));
            return character;
        }

        private int getModifier(string s)
        {
            int temp;
            bool success;
            success = int.TryParse(s, out temp);
            if (!success)
            {
                temp = 0;
            }
            return temp;
        }
    }
}