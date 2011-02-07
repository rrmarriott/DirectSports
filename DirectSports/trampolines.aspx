<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="trampolines.aspx.cs" Inherits="DirectSports.basketball_trampolines" Title="Direct Sports :: Trampolines" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Trampolines</h1>
<h2 class="h2Subsection">Round</h2>
<DSControls:ProductLister TableSummary="Round Trampolines" id="plRound" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plRound_ItemDataBound">
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

<h2 class="h2Subsection">Combination Units</h2>
<DSControls:ProductLister TableSummary="Combination Unit Trampolines" id="plCombination" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plRound_ItemDataBound">
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
<h2 class="h2Subsection">Jump King Accessories</h2>
    <uc1:NoImageProductLister ID="accessoriesList" ShowDescription="true" runat="server" />
</asp:Content>
