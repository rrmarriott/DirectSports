<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="athletics_kits.aspx.cs" Inherits="DirectSports.athletics_kits" Title="Direct Sports :: Athletics Kit" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Athletics Kit</h1>
<DSControls:ProductLister TableSummary="Athletics Kit Products" id="plAthleticsKitImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plAthleticsKitImages_ItemDataBound">
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
