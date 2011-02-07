<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_mini.aspx.cs" Inherits="DirectSports.basketball_mini" Title="Direct Sports :: Mini Basketball" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Mini Basketball</h1>
<DSControls:ProductLister TableSummary="Mini Basketball Products" id="plBasketballImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballImages_ItemDataBound">
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
For senior posts which can also be used for Mini Basketball, refer to the <a href="basketball_posts.aspx" title="Direct Sports Basketball Posts">Posts</a> section.
</p>
<br />
</asp:Content>
