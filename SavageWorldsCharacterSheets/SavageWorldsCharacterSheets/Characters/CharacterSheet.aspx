<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CharacterSheet.aspx.cs" Inherits="SavageWorldsCharacterSheets.Characters.CharacterSheet" %>

<asp:Content ID="Content" ContentPlaceHolderID="content" runat="server">
    <asp:ScriptManager runat="server" EnablePageMethods="true" EnablePartialRendering="true">
    </asp:ScriptManager>
    <div>
        <asp:Button ID="bnew" runat="server" OnClientClick="new_clicked(); return false;" Text="New" />
        <asp:Button ID="bsave" runat="server" Text="Save" OnClick="bsave_Click" />
    </div>
    <div class="left">
        <asp:TextBox runat="server" ID="tbname">Name</asp:TextBox>
        <asp:Table ID="characterTable" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Agility</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList runat="server" ID="ddlagility"></asp:DropDownList></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbagility" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server">Pace</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbpace" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server">Parry</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbparry" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server">Toughness</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbtoughness" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Smarts</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList runat="server" ID="ddlsmarts"></asp:DropDownList></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbsmarts" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Strength</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList runat="server" ID="ddlstrength"></asp:DropDownList></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbstrength" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Spirit</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList runat="server" ID="ddlspirit"></asp:DropDownList></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbspirit" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Vigor</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList runat="server" ID="ddlvigor"></asp:DropDownList></asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox runat="server" ID="tbvigor" CssClass="modifiertb"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:DropDownList runat="server" ID="ddladdskill">
            <asp:ListItem>Create New Skill</asp:ListItem>
        </asp:DropDownList><asp:Button runat="server" ID="baddskill" Text="Add" />
        <asp:Table ID="skillTable" runat="server">
        </asp:Table>
    </div>
    <div class="right">
        <asp:Table ID="characterList" runat="server">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Characters</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
    <script src="CharacterSheet.js"></script>
</asp:Content>
