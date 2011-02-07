<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="volleyball.aspx.cs" Inherits="DirectSports.volleyball" Title="Direct Sports :: Volleyball" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Volleyball</h1>
<h2 class="h2Subsection">Legea</h2>
<DSControls:ProductLister TableSummary="Legea Volleyball" id="plLegea" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plLegea_ItemDataBound">
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
<h2 class="h2Subsection">Stanno</h2>
    <DSControls:ProductLister TableSummary="Stanno Volleyball" id="plStanno" ColumnCount="3" CssClass="ImageLister" runat="server" OnItemDataBound="plStanno_ItemDataBound">
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
<b>For women’s shorts in the Stanno range, add &pound;4.25 + VAT.</b>
</p>

<p>
<b>Prices</b> are for a complete uniform i.e. top and shorts.
<br />
<b>Numbering</b> add &pound;2.00 + VAT per top.
<br />
<b>Printing</b> add &pound;1.50 + VAT per single colour print (e.g. for team name).
</p>
<p>
<b>For more details of the Legea range visit <a href="http://www.legea.com" title="Visit Legea">http://www.legea.com</a></b>
<br />
<b>For more details of the Stanno range visit <a href="http://www.stanno.co.uk" title="Visit Legea">http://www.stanno.co.uk</a></b>
</p>

<h2 class="h2Subsection">Volleyballs</h2>
<uc1:NoImageProductLister ID="vbVolleyballs" runat="server" />
</asp:Content>
