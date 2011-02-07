<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="football_kit_macron.aspx.cs" Inherits="DirectSports.football_kit_macron" Title="Direct Sports :: Macron Football Kit" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Football Kit - Macron</h1>
<ul>
<li>Prices are for Shirt and Shorts.</li>
<li>Shirts are available with either short or long sleeves.</li>
</ul>
<DSControls:ProductLister TableSummary="Macron Football Kit" id="plFootballKitImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plFootballKitImages_ItemDataBound">
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
<div id="divDirectBballBottomOptions">
<p>
<b>Numbers</b>
<br />
Per Shirt (9&quot;): &pound;1.70 (&pound;2.00 inc VAT)
<br />
4&quot; numbers (per digit): &pound;0.50 (&pound;0.59 inc VAT)
</p>
<p>
<b>Printing</b>
<br />
Per single colour print: &pound;1.50 (&pound;1.76 inc VAT)
</p>
</div>
<p>
For full details of the Macron range, visit <a href="http://www.macron.com" title="Visit Macron">http://www.macron.com</a>
</p>
</asp:Content>
