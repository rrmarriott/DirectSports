<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true"
    Codebehind="default.aspx.cs" Inherits="DirectSports._default" Title="Direct Sports :: Home" %>

<%@ Register Src="Controls/UserControls/SpecialOfferList.ascx" TagName="SpecialOfferList"
    TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContentArea" runat="server">
    <!--div class="divHomePageSection">
        <div class="divHomePageImageContainer">
            <img class="homepageimage" src="images/ds_home_ring.jpg" width="151" height="139" alt="Direct Sports Basketball Ring" />
        </div>
        <h1 class="sectionHeader homePageSectionHeader">
            <span class="italic">Welcome to </span><span class="emphasis">Direct Sports</span>
        </h1>
        <p>
            Direct Sports (Steeple Ashton, Wiltshire, UK) manufacture their own range 
            of quality basketball uniforms for schools and clubs 
            throughout the country. We also supply a full range of
            basketballs (Baden, Spalding) and equipment such 
            as portable goals, plus 'and 1' footwear. For further 
            information, please e-mail for a price list, or call to 
            discuss your requirements.
        </p>
    </div-->
    <div class="divHomePageSection">
        <div class="divHomePageImageContainer">
            <img class="homepageimage" src="images/ds_home_ball.jpg" width="153" height="151" alt="Direct Sports Basketball" />
        </div>
        <h1 class="sectionHeader homePageSectionHeader">
            <span class="italic">Top 5 </span><span class="emphasis">Offers</span>
        </h1>
        <uc1:SpecialOfferList ID="SpecialOfferList1" runat="server" />
    </div>
    <div class="divHomePageSection divLastHomePageSection">
        <div class="divHomePageImageContainer">
            <img class="homepageimage" src="images/ds_home_catrequest.jpg" width="151" height="140" alt="Direct Sports Catalogue Request" />
        </div>
        <h1 class="sectionHeader homePageSectionHeader">
            <span class="italic">Request </span><span class="emphasis">Information</span>
        </h1>
        <p>
            Ask Direct Sports a question by filling in a simple online form. We will respond to whatever your request is promptly whether it be a request for a catalogue, a query about delivery, or any other query you may have.
        </p>
        <a id="requestCat" href="requestinformation.aspx" title="Navigate to the request information page">Request Information</a>
    </div>
</asp:Content>
