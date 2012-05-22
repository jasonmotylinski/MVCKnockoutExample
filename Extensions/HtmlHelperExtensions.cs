using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCKnockoutExample.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString KOModelDataFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            var item = expression.Compile()(htmlHelper.ViewData.Model);
            var htmlString = string.Empty;

            if (item != null)
            {
                htmlString = string.Format(@"<script type=""text/javascript"">window.mvcKnockoutExample = {{modelData: {0}}};</script>", new JavaScriptSerializer().Serialize(item));
            }

            return MvcHtmlString.Create(htmlString);
        }
    }
}