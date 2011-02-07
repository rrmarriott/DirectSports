<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_balls.aspx.cs" Inherits="DirectSports.basketball_balls" Title="Direct Sports :: Basketballs" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketballs</h1>
<DSControls:ProductLister TableSummary="Basketball balls Products" id="plBasketballImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballImages_ItemDataBound">
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
Basketballs are available in size 5, 6 and 7.
</p>
<br />
</asp:Content>
