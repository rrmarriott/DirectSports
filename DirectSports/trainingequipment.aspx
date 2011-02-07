<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="trainingequipment.aspx.cs" Inherits="DirectSports.basketball_trainingequipment" Title="Direct Sports :: Training Equipment" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Training Equipment</h1>
<h2 class="h2Subsection">Training Equipment</h2>
<DSControls:ProductLister TableSummary="Training Equipment" id="plTrainingEquipment" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plTrainingEquipment_ItemDataBound">
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
<h2 class="h2Subsection">First Aid</h2>
    <uc1:NoImageProductLister ID="firstAidList" ShowDescription="true" runat="server" />
<h2 class="h2Subsection">Accessories</h2>
    <uc1:NoImageProductLister ID="accessoriesList" ShowDescription="true" runat="server" />
</asp:Content>
