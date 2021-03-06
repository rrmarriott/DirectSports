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
    public partial class basketball_trampolines : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindLists();
        }

        private void BindLists()
        {
            plRound.DataSource = ProductSectionEntity.LoadProductsForSection(47);
            plRound.DataBind();

            plCombination.DataSource = ProductSectionEntity.LoadProductsForSection(65);
            plCombination.DataBind();

            accessoriesList.ProductList = ProductSectionEntity.LoadProductsForSection(48);
        }

        protected void plRound_ItemDataBound(object sender, RepeaterItemEventArgs e)
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
