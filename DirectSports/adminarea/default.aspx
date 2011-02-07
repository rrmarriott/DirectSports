<%@ Page Language="C#" MasterPageFile="~/adminarea/MasterPages/DirectSportsAdmin.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DirectSports.adminarea._default" Title="Direct Sports :: Admin Home" %>
<asp:Content ID="conAdminHome" ContentPlaceHolderID="cphAdminContent" runat="server">
<h1>Administration</h1>
<p>
Choose what you would like to do.
</p>
<ul>
    <li><a href="productadmin.aspx" title="Edit details of a product">Edit product details</a></li>
    <li><!--a href="specialofferadmin.aspx" title="Edit details of special offers"-->Edit special offers (Currently Unavailable)<!--/a--></li>
</ul>
</asp:Content>