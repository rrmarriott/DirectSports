<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="racketsports.aspx.cs" Inherits="DirectSports.racketsports" Title="Direct Sports :: Racketsports" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Racketsports</h1>

<h2 class="h2Subsection">Racketball</h2>
<uc1:NoImageProductLister ID="racketballList" runat="server" />

<h2 class="h2Subsection">Squash</h2>
<uc1:NoImageProductLister ID="squashList" runat="server" />

<h2 class="h2Subsection">Tennis</h2>
<uc1:NoImageProductLister ID="tennisList" runat="server" />
</asp:Content>
