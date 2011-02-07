<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="football_goals.aspx.cs" Inherits="DirectSports.football_goals" Title="Direct Sports :: Football Goals and Nets" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Football Goals and Nets</h1>
<h2 class="h2Subsection">Goals and Nets</h2>
    <uc1:NoImageProductLister ID="listGoalsNets" runat="server" />
<h2 class="h2Subsection">PVC Football Goals</h2>
    <uc1:NoImageProductLister ID="listGoalsPvc" runat="server" />
</asp:Content>
