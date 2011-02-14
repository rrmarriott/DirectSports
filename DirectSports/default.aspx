<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true"
    CodeBehind="default.aspx.cs" Inherits="DirectSports._default" Title="Direct Sports :: Home" %>

<%@ Register Src="Controls/UserControls/SpecialOfferList.ascx" TagName="SpecialOfferList"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContentArea" runat="server">
    <div id="divHomePageAbout">
            <h1 class="sectionHeader">About Direct Sports</h1>
            <p>
&lsquo;Direct Sports&rsquo; of Wiltshire was started in 1995 in order to provide their own brand of
basketball kits to local schools and clubs.</p>
<p>
We now supply kit and equipment for most sports, and we have added team wear
from Italian brands Errea, Legea and Macron to our range, and our customers now
include schools, clubs and universities throughout the country.
</p>
<p>
In 2010, embroidery facilities were added so we are now able to supply a complete
range of leisurewear including polo shirts, sweatshirts, rain wear, sports bags etc.
</p>
<p>
Our web site shows only a small selection of items which are available from our
company. Please contact us if you are looking to purchase any items not shown and
we will do our best to source these products and provide you with a competitive
quotation.
</p>
<p>
Customers are encouraged to telephone or e-mail for further details, particularly with
regards to the purchase of team wear, so we can give you the information you require
about sizes, colours, fabrics etc.
</p>
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
