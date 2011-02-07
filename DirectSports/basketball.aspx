<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true"
    Codebehind="basketball.aspx.cs" Inherits="DirectSports.basketball" Title="Direct Sports :: Basketball" %>

<%@ Register TagPrefix="DSControls" Namespace="DirectSports.Controls.CustomControls"
    Assembly="DirectSports" %>
<asp:Content ID="conBasketball" ContentPlaceHolderID="mainContentArea" runat="server">
    <h1 class="sectionHeader">
        Basketball</h1>
    <p>
        Choose from a section listed below to view products in the basketball area.</p>
    <table summary="Basketball Product Areas" id="basketballProductAreas" class="ImageLister">
        <tr>
            <td>
                <a class="aNoHover" href="/basketball_direct.aspx" title="Basketball Uniforms - Direct Sports">
                <img src="/productimages/ds_dsbkit_club.jpg" id="imgDirectKits" alt="Basketball Uniforms - Direct Sports" />
                <br />
                <b>Direct Sports Uniforms</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/basketball_legea.aspx" title="Basketball Uniforms - Legea of Italy">
                <img src="/productimages/ds_legeakit_seattle.jpg" alt="Basketball Uniforms - Legea of Italy" />
                <br />
                <b>Legea of Italy Uniforms</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/basketball_errea.aspx" title="Basketball Uniforms - Errea">
                <img src="/productimages/ds_erreakit_jets.jpg" alt="Basketball Uniforms - Errea" />
                <br />
                <b>Errea Uniforms</b>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a class="aNoHover" href="/basketball_macron.aspx" title="Basketball Uniforms - Macron">
                <img src="/productimages/ds_macronbb_hornets.jpg" alt="Basketball Uniforms - Macron" />
                <br />
                <b>Macron Uniforms</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/basketball_accessoriesandref.aspx" title="Basketball Accessories and Referee Equipment">
                <img src="/productimages/ds_acc_balltrolley.jpg" alt="Basketball Accessories and Referee Equipment" />
                <br />
                <b>Accessories / Referees</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/basketball_scoring.aspx" title="Basketball Scoring Equipment">
                <img src="/productimages/ds_scoring_ttscollegiate.jpg" alt="Basketball Scoring Equipment" />
                <br />
                <b>Basketball Scoring Equipment</b>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a class="aNoHover" href="/basketball_rings.aspx" title="Basketball Rings">
                <img src="/productimages/ds_ring_flexcompetition.jpg" alt="Basketball Rings" />
                <br />
                <b>Basketball Rings</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/basketball_balls.aspx" title="Basketballs">
                <img src="/productimages/ds_bballs_baden471.jpg" alt="Basketballs" />
                <br />
                <b>Basketballs</b>
                </a>
            </td>
            <td>
                <a class="aNoHover" href="/basketball_posts.aspx" title="Basketball Posts">
                <img src="/productimages/ds_posts_ssgooseneck.jpg" alt="Basketball Posts" />
                <br />
                <b>Basketball Posts</b>
                </a>
            </td>
        </tr>
        <tr>
            <td>
                <a class="aNoHover" href="/basketball_mini.aspx" title="Mini Basketball">
                <img src="/productimages/ds_mini_skilcoach.jpg" alt="Mini Basketball" />
                <br />
                <b>Mini Basketball</b>
                </a>
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
