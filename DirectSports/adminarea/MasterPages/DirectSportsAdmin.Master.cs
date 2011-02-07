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

namespace DirectSports.adminarea.MasterPages
{
    public partial class DirectSportsAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litLoggedInMessage.Text = "You are logged in as <b>" + Page.User.Identity.Name + "</b> ";
        }
    }
}
