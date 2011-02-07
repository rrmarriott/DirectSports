using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DirectSports.BL.EntityClasses;

namespace DirectSports.Controls.UserControls
{
    public partial class SpecialOfferList : System.Web.UI.UserControl
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindOfferList();
            }
        }

        private void BindOfferList()
        {
            //gvSpecialOffers.DataSource = SpecialOfferEntity.GetSpecialOffers(SpecialOfferEntity.NumberOfOffers);
            //gvSpecialOffers.DataBind();
        }

        protected void gvSpecialOffers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                SpecialOfferEntity soe = e.Row.DataItem as SpecialOfferEntity;
                Literal litPriceInformation = e.Row.FindControl("litPriceInformation") as Literal;
                string priceString = (soe.Product.PriceIsFrom) ? "from " : string.Empty;
                priceString = priceString + "&pound;" + soe.Product.Price.ToString("f");
                priceString = (soe.Product.PriceIncludesVat) ? priceString + " inc VAT" : priceString + " ex VAT";
                litPriceInformation.Text = priceString;

                //add mouseovers for ie
                e.Row.Attributes.Add("onmouseover", "SpecialOfferGridOver(this);");
                e.Row.Attributes.Add("onmouseout", "SpecialOfferGridOut(this);");

                //add row clicks
                e.Row.Attributes.Add("onclick", string.Format("SpecialOfferGridClick('{0}');", soe.Product.ProductSection.Uri.Substring(1)));
            }
        }
    }
}