<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_legea.aspx.cs" Inherits="DirectSports.basketball_legea" Title="Direct Sports :: Basketball Uniforms - Legea of Italy" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Kits - Legea of Italy</h1>
<DSControls:ProductLister TableSummary="Legea Basketball Kits" id="plBasketballImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballImages_ItemDataBound">
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
Prices for playing uniforms include 4&quot; number on front, 8&quot; number on back of vests. &lsquo;DOUBLE&rsquo; has numbers attached on all four sides.
</p>
<p>
For single colour print (eg team name or player&lsquo;s name), add &pound;1.50 &#43 VAT per print.
</p>
<p>
For more details of the Legea range visit <a href="http://www.legea.com" title="Visit the Legea site" target="_blank">http://www.legea.com</a>
</p>
<br />
</asp:Content>
