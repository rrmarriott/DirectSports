using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace DirectSports.Controls.CustomControls
{
    public class ProductLister : Repeater
    {
        public string CssClass
        {
            get { return ViewState["m_CssClass"] as string; }
            set { ViewState["m_CssClass"] = value; }
        }

        public int ColumnCount
        {
            get { return (int) ViewState["m_ColumnCount"]; }
            set { ViewState["m_ColumnCount"] = value; }
        }

        public string TableSummary
        {
            get { return ViewState["m_TableSummary"] as string; }
            set { ViewState["m_TableSummary"] = value; }
        }
        
        public ProductLister()
        {
            //default
        }

        protected override void Render(HtmlTextWriter writer)
        {
            int rowCount = 0;
            writer.WriteBeginTag("table");
            writer.WriteAttribute("id", this.ClientID);
            writer.WriteAttribute("class", this.CssClass);
            writer.WriteAttribute("summary", this.TableSummary);
            writer.Write(HtmlTextWriter.TagRightChar);

            foreach (RepeaterItem ri in Items)
            {
                if (rowCount == 0)
                {
                    writer.WriteBeginTag("tr");
                    writer.Write(HtmlTextWriter.TagRightChar);
                }

                writer.WriteBeginTag("td");
                writer.Write(HtmlTextWriter.TagRightChar);
                ri.RenderControl(writer);
                writer.WriteEndTag("td");

                if (rowCount == this.ColumnCount - 1)
                {
                    writer.WriteEndTag("tr");
                    rowCount = 0;
                }
                else
                {
                    rowCount++;
                }
            }

            if (rowCount > 0)
            {
                //write any remaining td's
                while (rowCount < this.ColumnCount)
                {
                    writer.WriteBeginTag("td");
                    writer.Write(HtmlTextWriter.TagRightChar);
                    writer.Write("&nbsp;");
                    writer.WriteEndTag("td");
                    rowCount++;
                }

                writer.WriteEndTag("tr");
                //writer.cl
            }

            writer.WriteEndTag("table");
        }
    }
}
