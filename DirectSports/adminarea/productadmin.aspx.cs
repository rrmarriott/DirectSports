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
using AjaxControlToolkit;
using DirectSports.BL.EntityClasses;

namespace DirectSports.adminarea
{
    public partial class productadmin : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack && !IsCallback)
            {
                tvProductSections.Nodes.Add(LoadTreeNode(ProductSectionEntity.LoadRootSection("Product Sections")));
            }
        }

        private TreeNode LoadTreeNode(ProductSectionEntity childSection)
        {
            TreeNode childNode = new TreeNode();
            childNode.Value = childSection.Id.ToString();
            childNode.Text = childSection.Name;
            childNode.SelectAction = TreeNodeSelectAction.Select;

            foreach (ProductSectionEntity pse in ProductSectionEntity.GetChildSections(childSection.Id))
            {
                childNode.ChildNodes.Add(LoadTreeNode(pse));
            }

            return childNode;
        }

        private void LoadProducts(int sectionId)
        {
            gvProductList.DataSource = ProductSectionEntity.LoadAllProductsForSection(sectionId);
            gvProductList.DataBind();
            ViewState["CurrentSectionId"] = sectionId;
        }

        protected void tvProductSections_SelectedNodeChanged(object sender, EventArgs e)
        {
            tvProductSections.SelectedNode.ToggleExpandState();
            litProductSectionName.Text = string.Format("<h2 id=\"productSectionHeader\">{0}</h2>", tvProductSections.SelectedNode.Text);
            LoadProducts(int.Parse(tvProductSections.SelectedNode.Value));
        }

        protected void gvProductList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductList.PageIndex = e.NewPageIndex;
            LoadProducts((int)ViewState["CurrentSectionId"]);
        }

        protected void gvProductList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lnkEdit = e.Row.FindControl("lnkEdit") as LinkButton;
                ProductEntity product = e.Row.DataItem as ProductEntity;
                lnkEdit.Attributes.Add("onclick", "showPopWin('/adminarea/editproduct.aspx?id=" + product.Id.ToString() + "', '600', '500', UpdatePanel);");
            }
        }

        protected void btnUpdatePanel_Click(object sender, EventArgs e)
        {
            LoadProducts((int)ViewState["CurrentSectionId"]);
        }
    }
}
