<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_errea.aspx.cs" Inherits="DirectSports.basketball_errea" Title="Direct Sports :: Basketball Uniforms - Errea" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Kits - Errea</h1>
<DSControls:ProductLister TableSummary="Errea Basketball Kits" id="plBasketballImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballImages_ItemDataBound">
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
Prices for playing uniforms include 4&quot; number on front, 8&quot; number on back of vests, and on all 4 sides for reversible vests.
</p>
<p>
For players names, logos etc add &pound;1.50 &#43 VAT per print.
</p>
<p>
For more details of the Errea range visit <a href="http://www.errea.com" title="Visit the Errea site" target="_blank">http://www.errea.com</a>
</p>
<br />
</asp:Content>
