using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DirectSports.BL.EntityClasses;
using DirectSports.adminarea.helper;

namespace DirectSports.adminarea
{
    public partial class specialofferadmin : System.Web.UI.Page
    {
        private List<SpecialOfferEntity> m_Offers;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            m_Offers = ViewState["m_Offers"] as List<SpecialOfferEntity>;
            
            if (ViewState["m_Offers"] == null)
            {
                GetStoredOffers();
            }

            BindOfferGrid();
        }

        private void GetStoredOffers()
        {
            m_Offers = SpecialOfferEntity.GetSpecialOffers(short.Parse(WebConfigurationManager.AppSettings["SpecialOfferCount"]));
            ViewState["m_Offers"] = m_Offers;
        }

        private void BindOfferGrid()
        {
            gvProductList.DataSource = m_Offers;
            gvProductList.DataBind();
        }

        private void UpdateOfferPosition(int offerNumber, MoveDirection direction)
        {
            SpecialOfferEntity beingMoved = null;
            SpecialOfferEntity forcedToMove = null;
            int forcedToMoveNumber = (direction == MoveDirection.Down) ? offerNumber + 1 : offerNumber - 1;

            foreach (SpecialOfferEntity soe in m_Offers)
            {
                if (soe.Number == offerNumber)
                {
                    beingMoved = soe;
                }

                if (soe.Number == forcedToMoveNumber)
                {
                    forcedToMove = soe;
                }
            }

            //now switch the entities
            forcedToMove.Number = 1000;
            beingMoved.Number = (short) forcedToMoveNumber;
            forcedToMove.Number = (short)offerNumber;
        }

        protected void gvProductList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //do product name
                SpecialOfferEntity currentOffer = e.Row.DataItem as SpecialOfferEntity;
                Literal litProductName = e.Row.FindControl("litProductName") as Literal;
                litProductName.Text = currentOffer.Product.Name;
                
                if (e.Row.RowIndex == 0)
                {
                    LinkButton lnkMoveUp = e.Row.FindControl("lnkMoveUp") as LinkButton;
                    lnkMoveUp.Visible = false;
                }
                else if (e.Row.RowIndex == gvProductList.Rows.Count - 1)
                {
                    LinkButton lnkMoveDown = e.Row.FindControl("lnkMoveDown") as LinkButton;
                    lnkMoveDown.Visible = false;
                }
            }
        }

        [System.Web.Services.WebMethod]
        public string GiveSearchPopupContext(string contextKey)
        {
            ViewState["offerNumberForPopup"] = contextKey;
            return contextKey;
        }

        protected void btnSearchProducts_Click(object sender, EventArgs e)
        {
            List<ProductEntity> results = ProductEntity.SearchForProductsByName(txtProductName.Text);

            rblProductSearchResults.DataSource = results;
            rblProductSearchResults.DataTextField = "Name";
            rblProductSearchResults.DataValueField = "Id";
            rblProductSearchResults.DataBind();
            rblProductSearchResults.Visible = true;

            //upSpecialOffers.Update();
        }
    }
}
