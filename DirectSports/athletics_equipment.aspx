<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="athletics_equipment.aspx.cs" Inherits="DirectSports.athletics_equipment" Title="Direct Sports :: Athletics Equipment" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Athletics Equipment</h1>
    <uc1:NoImageProductLister ID="equipmentList" runat="server" />
</asp:Content>
