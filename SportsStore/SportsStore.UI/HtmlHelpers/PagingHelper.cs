using SportsStore.UI.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace SportsStore.UI.HtmlHelpers
{
    public static class PagingHelper
    {
        public static MvcHtmlString PageLinks(
            this HtmlHelper html,
            PagingInfo pagingInfo,
            Func<int,string> pageUrl)
        {
            if (pagingInfo.TotalPages <= 1)
                return null;

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i < pagingInfo.TotalPages; i++)
            {
                TagBuilder tagLi = new TagBuilder("li");

                if (i == pagingInfo.CurrentPage)
                    tagLi.AddCssClass("active");

                TagBuilder tagA = new TagBuilder("a");

                tagA.Attributes.Add("href", pageUrl(i));
                tagA.InnerHtml = i.ToString();

                tagLi.InnerHtml = tagA.ToString();

                stringBuilder.AppendLine(tagLi.ToString());
            }

            TagBuilder tagUl = new TagBuilder("ul");
            tagUl.AddCssClass("pagination");
            tagUl.InnerHtml = stringBuilder.ToString();

            return MvcHtmlString.Create(tagUl.ToString()) ;
        }

    }
}