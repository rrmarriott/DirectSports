<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="tabletennis.aspx.cs" Inherits="DirectSports.tabletennis" Title="Direct Sports :: Table Tennis" %>

<%@ Register Src="Controls/UserControls/NoImageProductLister.ascx" TagName="NoImageProductLister"
    TagPrefix="uc1" %>
<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls" Assembly="DirectSports" %>
<asp:Content ID="conMain" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Table Tennis</h1>

<h2 class="h2Subsection">Butterfly Indoor</h2>
<uc1:NoImageProductLister ID="ttIndoor" runat="server" />

<h2 class="h2Subsection">Butterfly Weatherproof</h2>
<uc1:NoImageProductLister ID="ttWeatherproof" runat="server" />
<p class="centered">
Most senior tables have a playback facility. They fold up in 2 movements, the first movement leaving one end upright. Tables marked * fold up in one movement, therefore this facility is not available. Tables marked # are stored in two separate sections.
</p>
<p class="centered">
All tables come complete with net and post set
</p>
<p class="centered">
Butterfly tables are recommended by the English Table Tennis Association
</p>
<table summary="Butterfly Table Tennis Tables" id="tableTennisTables" class="ImageLister">
    <tr>
        <td>
            <img src="/productimages/ds_tt_butcompact.jpg" alt="Butterfly Compact" />
            <br />
            <b>Butterfly Compact</b>
        </td>
        <td>
            <img src="/productimages/ds_tt_buthomerollaway.jpg" alt="Butterfly Home Rollaway" />
            <br />
            <b>Butterfly Home Rollaway</b>
        </td>
    </tr>
    <tr>
        <td>
            <img src="/productimages/ds_tt_butplaybackrollaway.jpg" alt="Butterfly Playback Rollaway" />
            <br />
            <b>Butterfly Playback Rollaway</b>
        </td>
        <td>
            <img src="/productimages/ds_tt_butpremiumrollaway.jpg" alt="Butterfly Premium Rollaway" />
            <br />
            <b>Butterfly Premium Rollaway</b>
        </td>
    </tr>
</table>
</asp:Content>
