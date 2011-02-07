<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NoImageProductLister.ascx.cs" Inherits="DirectSports.Controls.UserControls.NoImageProductLister" %>
<asp:Repeater ID="repNoImageListing" runat="Server" OnItemDataBound="repNoImageListing_ItemDataBound">
<HeaderTemplate>
<table summary="Products With No Image" class="tblNoImageProductList" cellspacing="0">
    <thead>
        <tr>
            <td>
                Product
            </td>
            <td id="descriptionHead" runat="server">
                Description
            </td>
            <td>
                Price
            </td>
        </tr>
    </thead>
</HeaderTemplate>
<ItemTemplate>
    <tr id="gridRow" runat="server">
        <td>
            <%# Eval("Name") %>
        </td>
        <td id="descriptionField" runat="server">
            <%# Eval("Description") %><b><asp:Literal ID="litDeliveryPrice" runat="server"></asp:Literal></b>
        </td>
        <td>
            <b><asp:Literal ID="litPriceInformation" runat="server"></asp:Literal></b>
        </td>
    </tr>
</ItemTemplate>
<FooterTemplate>
    </table>
</FooterTemplate>
</asp:Repeater>