using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.Adapters;
using System.Web.UI.WebControls;

namespace SexyAdapters
{
    public class LinkButtonAdapter : WebControlAdapter
    {
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            var linkButton = Control as LinkButton;
            linkButton.Text = string.Format("<span>{0}</span>", linkButton.Text);

            base.RenderContents(writer);
        }
    }
}
