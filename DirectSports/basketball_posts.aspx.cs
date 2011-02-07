using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DirectSports.BL.EntityClasses;

namespace DirectSports
{
    public partial class basketball_posts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindLists();
        }

        private void BindLists()
        {
            plInGroundImages.DataSource = ProductSectionEntity.LoadProductsForSection(7);
            plInGroundImages.DataBind();

            plPortableImages.DataSource = ProductSectionEntity.LoadProductsForSection(29);
            plPortableImages.DataBind();
        }

        protected void plInGroundImages_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            ProductEntity pe = e.Item.DataItem as ProductEntity;
            HtmlImage imgMainProductImage = e.Item.FindControl("imgProductImage") as HtmlImage;
            imgMainProductImage.Src = WebConfigurationManager.AppSettings["ProductImagesPath"] + pe.ImageName;
            imgMainProductImage.Alt = pe.Name;

            Literal litPriceInformation = e.Item.FindControl("litPriceInformation") as Literal;
            string priceString = (pe.PriceIsFrom) ? "from " : string.Empty;
            priceString = priceString + "&pound;" + pe.Price.ToString("f");
            priceString = (pe.PriceIncludesVat) ? priceString + " inc VAT" : priceString + " ex VAT";
            litPriceInformation.Text = priceString;

            Literal litDeliveryPrice = e.Item.FindControl("litDeliveryPrice") as Literal;
            string deliveryPriceString = (pe.DeliveryPrice > 0) ? "Delivery: " + pe.DeliveryPrice.ToString("f") : string.Empty;
            litDeliveryPrice.Text = deliveryPriceString;
        }

        protected void plPortableImages_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            ProductEntity pe = e.Item.DataItem as ProductEntity;
            HtmlImage imgMainProductImage = e.Item.FindControl("imgProductImage") as HtmlImage;
            imgMainProductImage.Src = WebConfigurationManager.AppSettings["ProductImagesPath"] + pe.ImageName;
            imgMainProductImage.Alt = pe.Name;

            Literal litPriceInformation = e.Item.FindControl("litPriceInformation") as Literal;
            string priceString = (pe.PriceIsFrom) ? "from " : string.Empty;
            priceString = priceString + "&pound;" + pe.Price.ToString("f");
            priceString = (pe.PriceIncludesVat) ? priceString + " inc VAT" : priceString + " ex VAT";
            litPriceInformation.Text = priceString;
        }
    }
}