<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true"
    Codebehind="athletics.aspx.cs" Inherits="DirectSports.athletics" Title="Direct Sports :: Athletics" %>

<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls"
    Assembly="DirectSports" %>
<asp:Content ID="conBasketball" ContentPlaceHolderID="mainContentArea" runat="server">
    <h1 class="sectionHeader">
        Athletics</h1>
    <p>
        Choose from a section listed below to view products in the athletics area.</p>
    <table summary="Athletics Product Areas" id="athleticsProductAreas" class="ImageLister">
        <tr>
            <td>
                <a class="aNoHover" href="/athletics_kits.aspx" title="Athletics Kit">
                <img src="/productimages/ds_athkit_legmik.jpg" id="imgAthKits" alt="Athletics Kit" />
                <br />
                <b>Athletics Kit</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/athletics_equipment.aspx" title="Athletics Equipment">
                <img src="/productimages/ds_athkit_400.jpg" alt="Athletics Equipment" />
                <br />
                <b>Athletics Equipment</b>
                </a>
            </td>
        </tr>
    </table>
</asp:Content>
