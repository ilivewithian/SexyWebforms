using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.Adapters;
using System.Web.UI.WebControls;

namespace SexyAdapters
{
    public class HyperLinkAdapter : WebControlAdapter
    {
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            var link = Control as HyperLink;
            link.Text = string.Format("<span>{0}</span>", link.Text);

            base.RenderContents(writer);
        }
    }
}
