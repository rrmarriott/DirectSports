using System;
using System.Web.UI;

namespace DirectSports.adminarea.MasterPages
{
    public partial class DirectSportsAdmin : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litLoggedInMessage.Text = "You are logged in as <b>" + Page.User.Identity.Name + "</b> ";
        }
    }
}
