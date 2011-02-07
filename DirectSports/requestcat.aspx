<%@ Page Language="C#" MasterPageFile="~/MasterPages/DirectSports.Master" AutoEventWireup="true" CodeBehind="requestcat.aspx.cs" Inherits="DirectSports.requestcat" Title="Direct Sports :: Request a Catalogue" %>
<asp:Content ID="conRequestCat" ContentPlaceHolderID="mainContentArea" runat="server">
<h1 class="sectionHeader">Request a Catalogue</h1>
<p>
If you would like to request a printed listing of products that we sell, you may request to be sent a catalogue (by post) here.
Simply choose the sports you are interested in below, fill in your contact details and we will send you a catalogue within 14 working days.
</p>
<fieldset>
<legend>Please Send Me a Catalogue for the Following Sports: </legend>
    <asp:CheckBoxList RepeatColumns="2" DataTextField="Name" DataValueField="Name" ID="clSports" runat="server">
    </asp:CheckBoxList>
</fieldset>

<fieldset class="hasFields">
<legend>My Contact Details Are: </legend>
<br />
    <asp:Label runat="server" ID="lblName" Text="Name:" AssociatedControlID="txtName"></asp:Label><asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Label runat="server" ID="lblAddress1" Text="Address:" AssociatedControlID="txtAddress1"></asp:Label><asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
    <asp:Label runat="server" ID="lblAddress2" Text="Address (Cont):" AssociatedControlID="txtAddress2"></asp:Label><asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
    <asp:Label runat="server" ID="lblAddress3" Text="Address (Cont):" AssociatedControlID="txtAddress3"></asp:Label><asp:TextBox ID="txtAddress3" runat="server"></asp:TextBox>
    <asp:Label runat="server" ID="lblPostcode" Text="Postcode:" AssociatedControlID="txtPostcode"></asp:Label><asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
    <asp:Label runat="server" ID="lblSubmit" Text=" " AssociatedControlID="txtPostcode"></asp:Label><asp:Button ID="btnRequestCatalogue" Width="10em" Text="Request Catalogue" runat="server" OnClick="btnRequestCatalogue_Click" />
</fieldset>
<p>
<asp:Label ID="lblCatalogueRequestResult" runat="server">Catalogue request sent.</asp:Label>
</p>
</asp:Content>
