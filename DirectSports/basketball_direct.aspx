<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_direct.aspx.cs" Inherits="DirectSports.basketball_direct" Title="Direct Sports :: Basketball Uniforms - Direct Sports" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Kits - Direct Sports</h1>
<DSControls:ProductLister TableSummary="Basketball Kit Products" id="plBasketballImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballImages_ItemDataBound">
<ItemTemplate>
<img id="imgProductImage" width="150" height="150" runat="server" />
<p class="parProductInfo">
<b>
<%# Eval("Name") %>
</b>
<br />
<b>
<asp:Literal ID="litPriceInformation" runat="server"></asp:Literal>
</b>
</p>
</ItemTemplate>
</DSControls:ProductLister>
<p>
<b>PRICES</b> are for a complete uniform i.e. numbered top and shorts.
<br />
<b>PRINTING</b> add &pound;1.50 &#43 VAT per single colour print (e.g. for team name).
<br />
<b>OPTIONS</b> V neck or U neck. Male or Female cut. Standard or Wide shoulders.
</p>
<div id="divDirectBballBottomOptions">
<p>
Prices shown for playing uniforms are <b>PER UNIFORM</b> which consists of a <b>VEST WITH ATTACHED NUMBERS and SHORTS</b>. Vests and shorts may be purchased separately. All shorts have &lsquo;Bonadex&rsquo; tie waist. Sets of 10 will normally be numbered 4-13, sets of 12 numbered 4-15 unless otherwise required.
</p>
<p>
<b>FABRICS</b>. Styles are available in up to <b>THREE DIFFERENT FABRICS and 15 COLOUR OPTIONS</b>.
</p>
<p>
<b>MICRO-SOFT</b>. Lightweight &lsquo;Mesh Look&rsquo; polyester.
<br />
<b>MICRO-DRI</b>. Medium weight &lsquo;Mesh-look&rsquo; polyester.
<br />
<b>PRO-DRI</b>. &lsquo;Mesh-look&rsquo; polyester with shiny finish.
</p>
</div>
</asp:Content>
