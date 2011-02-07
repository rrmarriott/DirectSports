using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DirectSports.BL.EntityClasses;

namespace DirectSports.Controls.UserControls
{
    public partial class NoImageProductLister : System.Web.UI.UserControl
    {
        private bool m_ShowDescription = true;
        private IList<ProductEntity> m_ProductList;

        public bool ShowDescription
        {
            set { m_ShowDescription = value; }
        }
	
        public IList<ProductEntity> ProductList
        {
            set { m_ProductList = value; }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            repNoImageListing.DataSource = m_ProductList;
            repNoImageListing.DataBind();
        }

        protected void repNoImageListing_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                ProductEntity pe = e.Item.DataItem as ProductEntity;
                Literal litPriceInformation = e.Item.FindControl("litPriceInformation") as Literal;
                string priceString = (pe.PriceIsFrom) ? "from " : string.Empty;
                priceString = priceString + "&pound;" + pe.Price.ToString("f");
                priceString = (pe.PriceIncludesVat) ? priceString + " inc VAT" : priceString + " ex VAT";
                litPriceInformation.Text = priceString;

                Literal litDeliveryPrice = e.Item.FindControl("litDeliveryPrice") as Literal;
                string deliveryPriceString = (pe.DeliveryPrice > 0) ? " Delivery: " + pe.DeliveryPrice.ToString("f") : string.Empty;
                litDeliveryPrice.Text = deliveryPriceString;

                if (!m_ShowDescription)
                {
                    e.Item.FindControl("descriptionField").Visible = false;
                }

                if (e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    HtmlTableRow row = e.Item.FindControl("gridRow") as HtmlTableRow;
                    row.Attributes.Add("class", "alternate");
                }
            }
            else if (e.Item.ItemType == ListItemType.Header)
            {
                if (!m_ShowDescription)
                {
                    e.Item.FindControl("descriptionHead").Visible = false;
                }
            }
        }
    }
}