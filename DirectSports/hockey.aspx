<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="hockey.aspx.cs" Inherits="DirectSports.hockey" Title="Direct Sports :: Hockey" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Hockey</h1>
<h2 class="h2Subsection">Clothing</h2>
<DSControls:ProductLister TableSummary="Hockey Clothing" id="plHockeyClothing" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plHockeyClothing_ItemDataBound">
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
<b>
Shirts are available with long or short sleeves.
<br />
Collar options; V neck, contrast collar or button collar.
</b>
</p>
<h2 class="h2Subsection">Equipment</h2>
    <uc1:NoImageProductLister ID="listHockeyEquipment" runat="server" />
</asp:Content>
