<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="netball.aspx.cs" Inherits="DirectSports.netball" Title="Direct Sports :: Netball" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Netball</h1>
<h2 class="h2Subsection">Netball Kit</h2>
<DSControls:ProductLister id="plNetballKit" TableSummary="Netball Kit" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plNetballKit_ItemDataBound">
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
<h2 class="h2Subsection">Netball Equipment</h2>
    <uc1:NoImageProductLister ID="listNetballEquipment" runat="server" />
</asp:Content>
