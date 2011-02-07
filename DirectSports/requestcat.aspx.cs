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
    public partial class requestcat : System.Web.UI.Page
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(requestcat));
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clSports.DataSource = ProductSectionEntity.GetTopLevelSections();
                clSports.DataBind();
            }

            lblCatalogueRequestResult.Visible = false;
        }

        protected void btnRequestCatalogue_Click(object sender, EventArgs e)
        {
            StringBuilder emailContent = new StringBuilder();
            emailContent.Append("<p>Direct Sports - Catalogue Request</p>");
            emailContent.Append("<p>Please send a catalogue for the following sports: </p>");

            foreach (ListItem li in clSports.Items)
            {
                if (li.Selected)
                {
                    emailContent.Append(li.Text + "<br />");
                }
            }

            emailContent.Append("<p>Please send a the catalogue(s) to: </p>");
            emailContent.Append("<p>");
            emailContent.Append(txtName.Text + "<br />");
            emailContent.Append(txtAddress1.Text + "<br />");
            emailContent.Append(txtAddress2.Text + "<br />");
            emailContent.Append(txtAddress3.Text + "<br />");
            emailContent.Append(txtPostcode.Text + "<br />");

            //send email
            MailManager manager = new MailManager();
            List<string> addresses = new List<string>(2);
            addresses.Add(WebConfigurationManager.AppSettings["AdminEmailAddress"]);
            addresses.Add(WebConfigurationManager.AppSettings["CatalogueEmailAddress"]);
            log.Info(emailContent.ToString());
            int numberSent;
            manager.SendEmail(addresses, "Direct Sports - Catalogue Request", WebConfigurationManager.AppSettings["AdminEmailAddress"], emailContent.ToString(), true, out numberSent);
            lblCatalogueRequestResult.Visible = true;
        }
    }
}
