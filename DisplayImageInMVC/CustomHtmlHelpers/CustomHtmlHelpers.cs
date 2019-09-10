using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayImageInMVC.CustomHtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlString Image(this HtmlHelper helper, string path, string alternateText)
        {
            TagBuilder tagBuilder = new TagBuilder("img");

            tagBuilder.Attributes.Add("src", VirtualPathUtility.ToAbsolute(path));
            tagBuilder.Attributes.Add("alt", alternateText);

            return new HtmlString(tagBuilder.ToString(TagRenderMode.SelfClosing));
        }
    }
}