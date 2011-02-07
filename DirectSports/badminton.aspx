<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="badminton.aspx.cs" Inherits="DirectSports.badminton" Title="Direct Sports :: Badminton" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Badminton</h1>
<DSControls:ProductLister TableSummary="Badminton Equipment" id="plBadmintonImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBadmintonImages_ItemDataBound">
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
<br />
<asp:Literal ID="litDeliveryPrice" runat="server"></asp:Literal>
</p>
</ItemTemplate>
</DSControls:ProductLister>
</asp:Content>
