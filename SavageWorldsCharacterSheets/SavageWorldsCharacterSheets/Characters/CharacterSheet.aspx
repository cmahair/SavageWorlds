<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CharacterSheet.aspx.cs" Inherits="SavageWorldsCharacterSheets.Characters.CharacterSheet" %>
<asp:Content ID="Content" ContentPlaceHolderID="content" runat="server">
    <button id="load" >Load</button>
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
</asp:Content>
