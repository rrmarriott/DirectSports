<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="rugby.aspx.cs" Inherits="DirectSports.rugby" Title="Direct Sports :: Rugby" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Rugby</h1>
<uc1:NoImageProductLister ID="listRugby" runat="server" />
<p>
<b>Clothing</b><br />
We are able to supply a range of shirts in either acrylic, poly/cotton or 100% cotton with fabric weights of 250 gsm, 320gsm and 420 gsm.
</p>
</asp:Content>
