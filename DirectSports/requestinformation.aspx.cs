using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;
using DirectSports.BL.EntityClasses;
using HighVoltage.Mail;
using log4net;

namespace DirectSports
{
    public partial class requestinformation : System.Web.UI.Page
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(requestcat));
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCatalogueRequestResult.Visible = false;
        }

        protected void btnRequestCatalogue_Click(object sender, EventArgs e)
        {
            StringBuilder emailContent = new StringBuilder();
            emailContent.Append("<p>Direct Sports - Information Request</p>");
            emailContent.Append("<p>Please respond to the below customer request: </p>");

            emailContent.Append("<p>");
            emailContent.Append("Customer E-Mail Address: ");
            emailContent.Append(txtEmail.Text);
            emailContent.Append("</p>");

            emailContent.Append("<p>");
            emailContent.Append(txtRequest.Text);
            emailContent.Append("</p>");

            //send email
            MailManager manager = new MailManager();
            List<string> addresses = new List<string>(2);
            addresses.Add(WebConfigurationManager.AppSettings["AdminEmailAddress"]);
            addresses.Add(WebConfigurationManager.AppSettings["CatalogueEmailAddress"]);
            log.Info(emailContent.ToString());
            int numberSent;
            manager.SendEmail(addresses, "Direct Sports - Information Request", WebConfigurationManager.AppSettings["AdminEmailAddress"], emailContent.ToString(), true, out numberSent);
            lblCatalogueRequestResult.Visible = true;
        }
    }
}
