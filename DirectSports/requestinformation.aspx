<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="requestinformation.aspx.cs" Inherits="DirectSports.requestinformation" Title="Direct Sports :: Request Information" %>
<asp:Content ID="conRequestCat" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Request Information</h1>
<p>
If you would like to request a printed listing of products that we sell, you may request to be sent a catalogue (by post) here. Alternatively any other information
    may be requested. Simply fill in the box below with your request and contact details,
    and they will be sent to us via E-Mail.</p>
<fieldset class="hasFields">
<legend>Information Request</legend>
<br />
    <asp:Label runat="server" ID="lblName" Text="Name:" AssociatedControlID="txtName"></asp:Label><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Label runat="server" ID="lblEmail" Text="E-Mail:" AssociatedControlID="txtEmail"></asp:Label><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="regEmail" runat="server" Display="Dynamic" ErrorMessage=" Please enter a valid email address." ControlToValidate="txtEmail" CssClass="errorMessage" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="reqEmail" runat="server" Display="Dynamic" ErrorMessage=" Please enter a valid email address." ControlToValidate="txtEmail" CssClass="errorMessage" SetFocusOnError="True"></asp:RequiredFieldValidator>
    <asp:Label runat="server" ID="lblRequest" Text="Request:" AssociatedControlID="txtRequest"></asp:Label><asp:TextBox ID="txtRequest" runat="server" TextMode="MultiLine" Rows="15"></asp:TextBox>
    &nbsp;&nbsp;<br />
    <asp:Label runat="server" ID="lblSubmit" Text=" " AssociatedControlID="btnRequestCatalogue"></asp:Label><asp:Button ID="btnRequestCatalogue" Width="10em" Text="Request Information" runat="server" OnClick="btnRequestCatalogue_Click" />
</fieldset>
<p>
<asp:Label ID="lblCatalogueRequestResult" runat="server">Your information has been sent to Direct Sports. Thank you.</asp:Label>
</p>
</asp:Content>
