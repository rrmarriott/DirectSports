<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="matsandbenches.aspx.cs" Inherits="DirectSports.matsandbenches" Title="Direct Sports :: Mats and Benches" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Mats and Benches</h1>
<DSControls:ProductLister TableSummary="Basketball Kit Products" id="plBasketballImages" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plBasketballImages_ItemDataBound">
<ItemTemplate>
<img id="imgProductImage" width="150" height="150" runat="server" />
<p class="parProductInfo">
<b>
<%# Eval("Name") %>
</b>
<br />
<div class="variationText">
    <b>
        <asp:Literal ID="litPriceInformation" runat="server"></asp:Literal>
    </b>
</div>
</p>
</ItemTemplate>
</DSControls:ProductLister>
<p>
<b>Delivery;</b> add &pound;5.00+VAT for orders under &pound;100
</p>
</asp:Content>
