<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_rings.aspx.cs" Inherits="DirectSports.basketball_rings" Title="Direct Sports :: Basketball Rings" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Rings</h1>
<DSControls:ProductLister TableSummary="Basketball Rings" id="plBasketballRingsImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballRingsImages_ItemDataBound">
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
</asp:Content>
