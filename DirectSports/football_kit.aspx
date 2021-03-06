<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="football_kit.aspx.cs" Inherits="DirectSports.football_kit" Title="Direct Sports :: Legea Football Kit" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Football Kit - Legea of Italy</h1>
<ul>
<li>Prices are for Shirt and Shorts.</li>
<li>Most styles are also available with short sleeves.</li>
</ul>
<DSControls:ProductLister TableSummary="Legea Football Kit" id="plFootballKitImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plFootballKitImages_ItemDataBound">
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
For full details of the Legea range, visit <a href="http://www.legea.com" title="Visit Legea">http://www.legea.com</a>
</p>
</asp:Content>
