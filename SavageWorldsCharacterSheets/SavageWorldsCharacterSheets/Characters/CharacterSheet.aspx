<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CharacterSheet.aspx.cs" Inherits="SavageWorldsCharacterSheets.Characters.CharacterSheet" %>
<asp:Content ID="Content" ContentPlaceHolderID="content" runat="server">
    <asp:Button ID="load" runat="server" OnClientClick="load_clicked();" Text="Load" />
    <table runat="server" id="characterTable">
        <tr>
            <th>Item</th>
            <th>Value</th>
        </tr>
        <tr>
            <td>Name: </td>
            <td id="name"></td>
        </tr>
    </table>
    <script src="CharacterSheet.js"></script>
    <asp:ScriptManager runat="server" EnablePageMethods="true" EnablePartialRendering="true">
        </asp:ScriptManager>
</asp:Content>
