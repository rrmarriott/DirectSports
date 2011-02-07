<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="cricket.aspx.cs" Inherits="DirectSports.cricket" Title="Direct Sports :: Cricket Equipment" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Cricket</h1>
<DSControls:ProductLister TableSummary="Cricket Equipment" id="plCricketImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plCricketImages_ItemDataBound">
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

</asp:Content>
