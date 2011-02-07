<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_posts.aspx.cs" Inherits="DirectSports.basketball_posts" Title="Direct Sports :: Basketball Posts" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Posts - Direct Sports</h1>
<h2 class="h2Subsection">In-Ground Units</h2>
<DSControls:ProductLister TableSummary="In-Ground Basketball Goals" id="plInGroundImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plInGroundImages_ItemDataBound">
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
<br />
<%# Eval("Description") %>
<br />
<asp:Literal ID="litDeliveryPrice" runat="server"></asp:Literal>
<br />
<b>
<%# Eval("ExtraInformation") %>
</b>
</p>
</ItemTemplate>
</DSControls:ProductLister>
<h2 class="h2Subsection">Portable Units</h2>
<DSControls:ProductLister id="plPortableImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plPortableImages_ItemDataBound">
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
<br />
<%# Eval("Description") %>
</p>
</ItemTemplate>
</DSControls:ProductLister>
</asp:Content>
