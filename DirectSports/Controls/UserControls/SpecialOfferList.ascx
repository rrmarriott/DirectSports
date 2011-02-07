<%@ Control Language="C#" AutoEventWireup="true" Codebehind="SpecialOfferList.ascx.cs"
    Inherits="DirectSports.Controls.UserControls.SpecialOfferList" %>
<%-- <asp:GridView CssClass="specialOfferGrid" ID="gvSpecialOffers" ShowFooter="false" ShowHeader="false" AutoGenerateColumns="false" BorderStyle="None" runat="server" OnRowDataBound="gvSpecialOffers_RowDataBound" GridLines="None">
<Columns>
<asp:TemplateField ItemStyle-Width="5%">
    <ItemTemplate>
        <%# Eval("Number") %>.
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
    <ItemTemplate>
        <%# Eval("Product.Name") %>
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
    <ItemTemplate>
        <asp:Literal ID="litPriceInformation" runat="server"></asp:Literal>
    </ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
    <ItemTemplate>
        <a href='<%# Eval("Product.ProductSection.Uri") %>' runat="server">Info</a>
    </ItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>--%>
<table summary="Current Special Offers from Direct Sports" class="specialOfferGrid" cellspacing="0" border="0" id="ctl00_mainContentArea_SpecialOfferList1_gvSpecialOffers" style="border-style: None; border-collapse: collapse;">
    <tr>
        <td style="width: 5%;">
            1.
        </td>
        <td>
            Football Kit (shirt and shorts)
        </td>
        <td>
            from &pound;6.75 + VAT
        </td>
    </tr>
    <tr>
        <td style="width: 5%;">
            2.
        </td>
        <td>
            Basketball Uniforms (vest with attached numbers and shorts)
        </td>
        <td>
            from &pound;10.00 + VAT
        </td>
    </tr>
    <tr>
        <td style="width: 5%;">
            3.
        </td>
        <td>
            Volleyball Kit (top with attached numbers and shorts)
        </td>
        <td>
            from &pound;10.00 + VAT
        </td>
    </tr>
    <tr>
        <td style="width: 5%;">
            4.
        </td>
        <td>
            Molten GG7 Basketball
        </td>
        <td>
            &pound;30.00 + VAT
        </td>
    </tr>
</table>
<br />