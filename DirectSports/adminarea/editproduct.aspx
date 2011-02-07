<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editproduct.aspx.cs" Inherits="DirectSports.adminarea.editproduct" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit Product</title>
    <link href="/adminarea/styles/forms.css" rel="stylesheet" type="text/css" />
    <link href="/adminarea/styles/admin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
        <legend><asp:Literal ID="litProductName" runat="server"></asp:Literal></legend>
            <asp:Label ID="lblProdId" runat="server" Text="ID:" AssociatedControlID="txtProdId"></asp:Label>
            <asp:Label ID="txtProdId" runat="server"></asp:Label><br />
            <asp:Label ID="lblProdName" runat="server" Text="Name:" AssociatedControlID="txtProdName"></asp:Label>
            <asp:TextBox ID="txtProdName" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblProdDescription" runat="server" AssociatedControlID="txtProdDescription" Text="Description:"></asp:Label>
            <asp:TextBox ID="txtProdDescription" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox><br />
            <asp:Label ID="lblExtraInformation" runat="server" AssociatedControlID="txtExtraInformation" Text="Extra Information:"></asp:Label>
            <asp:TextBox ID="txtExtraInformation" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox><br />
            <asp:Label ID="lblProdPrice" runat="server" AssociatedControlID="txtProdPrice" Text="Price (£):"></asp:Label>
            <asp:TextBox ID="txtProdPrice" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPriceFrom" runat="server" AssociatedControlID="chkPriceIsFrom" Text='Price Is "From":'></asp:Label>
            <asp:CheckBox ID="chkPriceIsFrom" runat="server" CssClass="checkbox" /><br />
            <asp:Label ID="lblIncludesVat" runat="server" AssociatedControlID="chkIncludesVat" Text="Price Includes VAT:"></asp:Label>
            <asp:CheckBox ID="chkIncludesVat" runat="server" CssClass="checkbox" /><br />
            <asp:Label ID="lblVisible" runat="server" AssociatedControlID="chkVisible" Text="Product Visible on Website:"></asp:Label>
            <asp:CheckBox ID="chkVisible" runat="server" CssClass="checkbox" /><br /><br />
            <asp:Label ID="lblDeliveryPrice" runat="server" AssociatedControlID="txtDeliveryPrice" Text="Delivery Price (£):"></asp:Label>
            <asp:TextBox ID="txtDeliveryPrice" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblImageFile" runat="server" AssociatedControlID="txtImageFileName" Text="Image File Name:"></asp:Label>
            <asp:TextBox ID="txtImageFileName" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblUpdate" runat="server" AssociatedControlID="btnUpdate" ></asp:Label>
            <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button" OnClick="btnDelete_Click" OnClientClick="parent.hidePopWin(true);alert('Product Deleted')" />
            <input type="reset" class="button" value="Reset" />
            <input type="button" class="button" value="Close" onclick="parent.hidePopWin(true);" />
        </fieldset>
    </div>
    </form>
</body>
</html>
