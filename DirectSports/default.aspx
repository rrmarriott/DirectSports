<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true"
    CodeBehind="default.aspx.cs" Inherits="DirectSports._default" Title="Direct Sports :: Home" %>

<%@ Register Src="Controls/UserControls/SpecialOfferList.ascx" TagName="SpecialOfferList"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContentArea" runat="server">
    <div id="divHomePageAbout">
            <h1 class="sectionHeader">About Direct Sports</h1>
            <p>
            &lsquo;Direct Sports of Wiltshire&rsquo; have been providing quality kit and equipment
            to schools and clubs around the country for over 10 years. Although the company
            started out by manufacturing their own basketball kit, it now supplies kit and equipment
            for most sports and is the local distributor for LEGEA sportswear. Our aim is to
            provide good quality products at affordable prices so please contact us to discuss
            your requirements.</p>
    </div>
    <div class="divHomePageSection divLastHomePageSection">
        <div class="divHomePageImageContainer">
            <img class="homepageimage" src="images/ds_home_catrequest.jpg" width="151" height="140" alt="Direct Sports Catalogue Request" />
        </div>
        <h1 class="sectionHeader homePageSectionHeader">
            <span class="italic">Request </span><span class="emphasis">Information</span>
        </h1>
        <p>
            Ask Direct Sports a question by filling in a simple online form. We will respond
            to whatever your request is promptly whether it be a request for a catalogue, a
            query about delivery, or any other query you may have.
        </p>
        <a id="requestCat" href="requestinformation.aspx" title="Navigate to the request information page">
            Request Information</a>
    </div>
</asp:Content>
