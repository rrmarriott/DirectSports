<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_scoring.aspx.cs" Inherits="DirectSports.basketball_scoring" Title="Direct Sports :: Scoring Equipment" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Scoring Eqipment</h1>
<DSControls:ProductLister TableSummary="Basketball Scoring Equipment" id="plBasketballScoring" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballScoring_ItemDataBound">
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
