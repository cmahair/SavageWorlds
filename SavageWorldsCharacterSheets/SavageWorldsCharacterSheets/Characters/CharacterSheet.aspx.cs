using SavageWorldsCharacterSheets.Data;
using SavageWorldsCharacterSheets.Tools;
using System;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace SavageWorldsCharacterSheets.Characters
{
    public partial class CharacterSheet : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BuildAttributeTable();
            }
        }

        protected override void OnInit(EventArgs e)
        {
            BuildCharacterListTable();
        }

        [WebMethod]
        public static Character NewCharacter()
        {
            Character character = new Character("Enter Name");
            CharacterSheet page = HttpContext.Current.Handler as CharacterSheet;
            page.ViewState["character"] = character;
            return character;
        }

        private void BuildAttributeTable()
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
            Character character = new Character();
            character.Name = tbname.Text;
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

        private void BuildCharacterListTable()
        {
            string[] characters = DataManager.Characters();
            foreach (string character in characters)
            {
                TableRow row = new TableRow();
                TableCell cell = new TableCell();
                Button button = new Button();
                button.Text = character;
                button.Click += new EventHandler(LoadCharacter);
                //cell.Text = character;
                cell.Controls.Add(button);
                row.Cells.Add(cell);
                characterList.Rows.Add(row);
            }
        }

        public void LoadCharacter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Character character = DataManager.LoadCharacter(button.Text);
            tbname.Text = character.Name;
            tbpace.Text = character.Pace.ToString();
            tbparry.Text = character.Parry.ToString();
            tbtoughness.Text = character.Toughness.ToString();
            ddlagility.SelectedValue = character.Agility.DieType.ToString();
            tbagility.Text = character.Agility.Modifier.ToString();
            ddlsmarts.SelectedValue = character.Smarts.DieType.ToString();
            tbsmarts.Text = character.Smarts.Modifier.ToString();
            ddlstrength.SelectedValue = character.Strength.DieType.ToString();
            tbstrength.Text = character.Strength.Modifier.ToString();
            ddlspirit.SelectedValue = character.Spirit.DieType.ToString();
            tbspirit.Text = character.Spirit.Modifier.ToString();
            ddlvigor.SelectedValue = character.Vigor.DieType.ToString();
            tbvigor.Text = character.Vigor.Modifier.ToString();
        }
    }
}