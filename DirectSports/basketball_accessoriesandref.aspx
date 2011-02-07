<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_accessoriesandref.aspx.cs" Inherits="DirectSports.basketball_accessoriesandref" Title="Direct Sports :: Basketball Accessories & Referees' Equipment" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Accessories & Referees' Equipment</h1>
<h2 class="h2Subsection">Accessories</h2>
<DSControls:ProductLister TableSummary="Basketball Accessories and Referee Products" id="plBasketballImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballImages_ItemDataBound">
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
<h2 class="h2Subsection">Referees</h2>
    <uc1:NoImageProductLister ID="refList" ShowDescription="true" runat="server" />
<div id="divRefBottom">
    <img id="imgRefShirt" alt="Referee Shirt" title="Referee Shirt" height="150" width="150" runat="server" />
</div>
</asp:Content>
