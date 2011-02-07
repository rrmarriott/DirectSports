using System;
using System.Web;
using DirectSports.BL.EntityClasses;
using System.Threading;

namespace DirectSports.adminarea
{
    public partial class editproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            
            if (!IsPostBack)
            {
                int productId = int.Parse(Request.QueryString["id"]);
                LoadForm(productId);
            }
        }

        private void LoadForm(int productId)
        {
            var product = ProductEntity.LoadProductById(productId);
            txtProdId.Text = productId.ToString();
            txtProdName.Text = product.Name;
            txtProdDescription.Text = product.Description;
            txtExtraInformation.Text = product.ExtraInformation;
            txtProdPrice.Text = product.Price.ToString("f");
            chkIncludesVat.Checked = product.PriceIncludesVat;
            chkPriceIsFrom.Checked = product.PriceIsFrom;
            chkVisible.Checked = product.Enabled;
            txtDeliveryPrice.Text = product.DeliveryPrice.ToString("f");
            txtImageFileName.Text = product.ImageName;
            litProductName.Text = "Details: " + product.Name;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            var toSave = new ProductEntity(int.Parse(txtProdId.Text));
            toSave.IsNew = false;
            toSave.Name = txtProdName.Text;
            toSave.Description = txtProdDescription.Text;
            toSave.ExtraInformation = txtExtraInformation.Text;
            toSave.Price = decimal.Parse(txtProdPrice.Text);
            toSave.PriceIncludesVat = chkIncludesVat.Checked;
            toSave.PriceIsFrom = chkPriceIsFrom.Checked;
            toSave.Enabled = chkVisible.Checked;
            toSave.DeliveryPrice = decimal.Parse(txtDeliveryPrice.Text);
            toSave.ImageName = txtImageFileName.Text;
            toSave.Save();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Thread.Sleep(200);
            var toDelete = new ProductEntity(int.Parse(txtProdId.Text));
            toDelete.Delete();
        }
    }
}
