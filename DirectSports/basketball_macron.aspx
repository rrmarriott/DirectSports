<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="basketball_macron.aspx.cs" Inherits="DirectSports.basketball_macron" Title="Direct Sports :: Macron Basketball Kits" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Basketball Kits - Macron</h1>
<h2 class="h2Subsection">Male</h2>
<DSControls:ProductLister TableSummary="Male basketball kit by Macron" id="plMacronKitMale" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plMacronKitMale_ItemDataBound">
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

<h2 class="h2Subsection">Female</h2>
<DSControls:ProductLister TableSummary="Female basketball kit by Macron" id="plMacronKitFemale" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plMacronKitFemale_ItemDataBound">
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

<h2 class="h2Subsection">Training Tops</h2>
<DSControls:ProductLister TableSummary="Basketball training tops by Macron" id="plMacronKitTT" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plMacronKitTT_ItemDataBound">
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
Prices shown are inclusive of numbering for vests 4&quot; front 8&quot; back and on all 4 sides for reversible vests.
</p>
<p>
For player&lsquo;s names, logo etc add &pound;1.50 &#43 VAT per print.
</p>
<p>
For more details of the Macron range visit <a href="http://www.macron.com" title="Visit the Macron site" target="_blank">http://www.macron.com</a>
</p>
<br />
</asp:Content>
