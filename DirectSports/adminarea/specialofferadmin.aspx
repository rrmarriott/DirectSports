<%@ Page Language="C#" MasterPageFile="~/adminarea/MasterPages/DirectSportsAdmin.Master" AutoEventWireup="true" CodeBehind="specialofferadmin.aspx.cs" Inherits="DirectSports.adminarea.specialofferadmin" Title="Direct Sports :: Special Offer Admin" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="atlasToolkit" %>
<asp:Content ID="conSpecialOfferAdmin" ContentPlaceHolderID="cphAdminContent" runat="server">
<h1>Special Offer Administration</h1>

<asp:UpdatePanel ID="upSpecialOffers" runat="server">
    <ContentTemplate>
        <asp:Panel ID="changeProductPanel" CssClass="modalPopup" runat="server">
            <h2>Change Special Offer Product <asp:Label ID="pnlOfferNumber" runat="server"></asp:Label></h2>
            <fieldset>
            <legend>Search By Product Name</legend>
            <asp:Label AssociatedControlID="txtProductName" ID="lblProductNameSearch" Text="Product Name: " runat="server"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <%--<asp:UpdatePanel ID="upChooseProduct" runat="server">
        <ContentTemplate>--%>
            <asp:LinkButton ID="btnSearchProducts" Text="Find Products" runat="server" OnClick="btnSearchProducts_Click" />
            </fieldset>
            <fieldset>
            <legend>Search Results</legend>
                <div id="searchResults">
                    <asp:RadioButtonList ID="rblProductSearchResults" Visible="false" runat="server"></asp:RadioButtonList>
                </div>           
            </fieldset>
            
            <asp:Button runat="server" Text="OK" ID="btnOkChangeProduct" />
            <asp:Button runat="server" Text="Cancel" ID="btnCancelChangeProduct" />
            <%-- </ContentTemplate>
            </asp:UpdatePanel>--%>
        </asp:Panel>
        <asp:GridView CssClass="DefaultGrid" GridLines="None" ID="gvProductList" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvProductList_RowDataBound">
            <Columns>
                <asp:BoundField AccessibleHeaderText="Offer Number" DataField="Number" HeaderText="Offer Number" ReadOnly="True" />
                <asp:TemplateField AccessibleHeaderText="Product Name" HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Literal ID="litProductName" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="Change Product" HeaderText="Change Product" ShowHeader="False">
                    <ItemStyle HorizontalAlign="Center" />
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemTemplate>
                        <atlasToolkit:ModalPopupExtender ID="mpeChangeProduct" runat="server" DynamicControlID="pnlOfferNumber" DynamicServiceMethod="GiveSearchPopupContext" DynamicContextKey='<%# Eval("Number") %>' DropShadow="true" BackgroundCssClass="modalBackground" PopupControlID="changeProductPanel" TargetControlID="lnkChange" OkControlID="btnOkChangeProduct" CancelControlID="btnCancelChangeProduct" />
                        <asp:LinkButton CommandArgument='<%# Eval("Number") %>' ID="lnkChange" runat="server" CausesValidation="false"
                            CommandName="ChangeProduct" Text="Change" CssClass="changeProduct"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="Move Down" HeaderText="Move Down" ShowHeader="False">
                    <ItemStyle HorizontalAlign="Center" />
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemTemplate>
                        <asp:LinkButton CommandArgument='<%# Eval("Number") %>' ID="lnkMoveDown" runat="server" CausesValidation="false"
                            CommandName="MoveProductDown" Text=""><img src="~/images/ds_move_down.gif" alt="Move Down" height="11" width="11" runat="server" /></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="Move Up" HeaderText="Move Up" ShowHeader="False">
                    <ItemStyle HorizontalAlign="Center" />
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemTemplate>
                        <asp:LinkButton CommandArgument='<%# Eval("Number") %>' ID="lnkMoveUp" runat="server" CausesValidation="false"
                            CommandName="MoveProductUp" Text=""><img src="~/images/ds_move_up.gif" alt="Move Up" height="11" width="11" runat="server" /></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle CssClass="DefaultGridRow" />
            <HeaderStyle CssClass="DefaultGridHeader" />
            <AlternatingRowStyle CssClass="DefaultGridRowAlternate" />
        </asp:GridView>

            
        
        
     </ContentTemplate>
            </asp:UpdatePanel>   
</asp:Content>