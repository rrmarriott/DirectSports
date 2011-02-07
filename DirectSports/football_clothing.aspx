<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="football_clothing.aspx.cs" Inherits="DirectSports.football_clothing" Title="Direct Sports :: Football Clothing" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Football Clothing</h1>
<h2 class="h2Subsection">Legea</h2>
<DSControls:ProductLister TableSummary="Legea Football Clothing" id="plFootballClothingLegea" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plFootballClothing_ItemDataBound">
<ItemTemplate>
<img id="imgProductImage" width="150" height="150" runat="server" />
<p class="parProductInfo">
<b>
<%# Eval("Name") %>
</b>
<br />
<%# Eval("Description") %>
<br />
<b>
<asp:Literal ID="litPriceInformation" runat="server"></asp:Literal>
</b>
</p>
</ItemTemplate>
</DSControls:ProductLister>
<p>
For full details of the Legea range, visit <a href="http://www.legea.com" title="Visit Legea">http://www.legea.com</a>
</p>

<h2 class="h2Subsection">Macron</h2>
<DSControls:ProductLister TableSummary="Macron Football Clothing" id="plFootballClothingMacron" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plFootballClothing_ItemDataBound">
<ItemTemplate>
<img id="imgProductImage" width="150" height="150" runat="server" />
<p class="parProductInfo">
<b>
<%# Eval("Name") %>
</b>
<br />
<%# Eval("Description") %>
<br />
<b>
<asp:Literal ID="litPriceInformation" runat="server"></asp:Literal>
</b>
</p>
</ItemTemplate>
</DSControls:ProductLister>
<p>
For full details of the Macron range, visit <a href="http://www.macron.com" title="Visit Macron">http://www.macron.com</a>
</p>
</asp:Content>
