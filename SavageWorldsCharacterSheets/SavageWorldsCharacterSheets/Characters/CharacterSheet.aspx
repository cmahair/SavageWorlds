<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CharacterSheet.aspx.cs" Inherits="SavageWorldsCharacterSheets.Characters.CharacterSheet" %>

<asp:Content ID="Content" ContentPlaceHolderID="content" runat="server">
    <div>
        <asp:Button ID="bnew" runat="server" OnClientClick="new_clicked(); return false;" Text="New" />
        <asp:Button ID="bload" runat="server" OnClientClick="load_clicked();" Text="Load" />
        <asp:Button ID="bsave" runat="server" OnClientClick="save_clicked();" Text="Save" OnClick="bsave_Click" />
    </div>
    <asp:TextBox runat="server" ID="tbname" >Name</asp:TextBox>
    <asp:Table ID="characterTable" runat="server" >
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Agility</asp:TableCell>
            <asp:TableCell runat="server"><asp:DropDownList runat="server" ID="ddlagility"></asp:DropDownList></asp:TableCell>
            <asp:TableCell runat="server">Pace</asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox runat="server" ID="tbpace"></asp:TextBox></asp:TableCell>
            <asp:TableCell runat="server">Parry</asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox runat="server" ID="tbparry"></asp:TextBox></asp:TableCell>
            <asp:TableCell runat="server">Toughness</asp:TableCell>
            <asp:TableCell runat="server"><asp:TextBox runat="server" ID="tbtoughness"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Smarts</asp:TableCell>
            <asp:TableCell runat="server"><asp:DropDownList runat="server" ID="ddlsmarts"></asp:DropDownList></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Strength</asp:TableCell>
            <asp:TableCell runat="server"><asp:DropDownList runat="server" ID="ddlstrength"></asp:DropDownList></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Spirit</asp:TableCell>
            <asp:TableCell runat="server"><asp:DropDownList runat="server" ID="ddlspirit"></asp:DropDownList></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Vigor</asp:TableCell>
            <asp:TableCell runat="server"><asp:DropDownList runat="server" ID="ddlvigor"></asp:DropDownList></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <script src="CharacterSheet.js"></script>
    <asp:ScriptManager runat="server" EnablePageMethods="true" EnablePartialRendering="true">
    </asp:ScriptManager>
</asp:Content>
