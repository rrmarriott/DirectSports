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
using System.Text;

namespace DirectSports
{
    public partial class basketball_direct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindLists();
        }

        private void BindLists()
        {
            plBasketballImages.DataSource = ProductSectionEntity.LoadProductsForSection(2);
            plBasketballImages.DataBind();
        }

        protected void plBasketballImages_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            ProductEntity pe = e.Item.DataItem as ProductEntity;
            HtmlImage imgMainProductImage = e.Item.FindControl("imgProductImage") as HtmlImage;
            imgMainProductImage.Src = WebConfigurationManager.AppSettings["ProductImagesPath"] + pe.ImageName;
            imgMainProductImage.Alt = pe.Name;

            Literal litPriceInformation = e.Item.FindControl("litPriceInformation") as Literal;

            if (pe.ProductVariation.Count == 0)
            {                
                string priceString = (pe.PriceIsFrom) ? "from " : string.Empty;
                priceString = priceString + "&pound;" + pe.Price.ToString("f");
                priceString = (pe.PriceIncludesVat) ? priceString + " inc VAT" : priceString + " ex VAT";
                litPriceInformation.Text = priceString;
            }
            else
            {
                StringBuilder priceString = new StringBuilder();

                foreach (ProductVariationEntity pve in pe.ProductVariation)
                {
                    priceString.Append(pve.Text + "&nbsp;");
                    priceString.Append((pve.PriceIsFrom) ? "from " : string.Empty);
                    priceString.Append("&pound;" + pve.Price.ToString("f"));
                    priceString.Append((pve.PriceIncludesVat) ? " inc VAT" : " ex VAT");
                    priceString.Append("<br />");
                }

                priceString.Remove(priceString.Length - 6, 6);
                litPriceInformation.Text = priceString.ToString();
            }
        }
    }
}
