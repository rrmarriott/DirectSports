<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true"
    Codebehind="football.aspx.cs" Inherits="DirectSports.football" Title="Direct Sports :: Football" %>

<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls"
    Assembly="DirectSports" %>
<asp:Content ID="conFootball" ContentPlaceHolderID="mainContentArea" runat="server">
    <h1 class="sectionHeader">
        Football</h1>
    <p>
        Choose from a section listed below to view products in the football area.</p>
    <table summary="Football Product Areas" id="footballProductAreas" class="ImageLister">
        <tr>
            <td>
                <a class="aNoHover" href="/football_kit.aspx" title="Legea Football Kit">
                <img src="/productimages/ds_footkit_london.jpg" id="imgFootKitLegea" alt="Legea Football Kit" />
                <br />
                <b>Legea Football Kit</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/football_kit_macron.aspx" title="Macron Football Kit">
                <img src="/productimages/ds_fkitmacron_aragon.jpg" id="imgFootKitMacron" alt="Macron Football Kit" />
                <br />
                <b>Macron Football Kit</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/football_kit_errea.aspx" title="Errea Football Kit">
                <img src="/productimages/ds_fkiterrea_orion.jpg" id="imgFootKitErrea" alt="Errea Football Kit" />
                <br />
                <b>Errea Football Kit</b>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a class="aNoHover" href="/football_balls.aspx" title="Footballs">
                <img src="/productimages/ds_fballs_mitrealto.jpg" alt="Footballs" />
                <br />
                <b>Footballs</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/football_goals.aspx" title="Football Goals and Nets">
                <img src="/productimages/ds_fballs_mitrealto.jpg" id="img1" alt="Football Goals and Nets" />
                <br />
                <b>Football Goals and Nets</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/football_clothing.aspx" title="Football Clothing">
                <img src="/productimages/ds_footcloth_malta.jpg" alt="Football Clothing" />
                <br />
                <b>Football Clothing</b>
                </a>
            </td>
        </tr>
    </table>
</asp:Content>
