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
    public partial class athletics_kits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindLists();
        }

        private void BindLists()
        {
            plAthleticsKitImages.DataSource = ProductSectionEntity.LoadProductsForSection(10);
            plAthleticsKitImages.DataBind();
        }

        protected void plAthleticsKitImages_ItemDataBound(object sender, RepeaterItemEventArgs e)
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
