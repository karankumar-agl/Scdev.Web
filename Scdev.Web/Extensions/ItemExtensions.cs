using Sitecore.Data.Items;
using Sitecore.Links;
using System;

namespace Scdev.Web.Extensions
{
    public static class ItemExtensions
    {
        public static string Url(this Item item, UrlOptions options=null)//ItemUrlBuilderOptions options=null
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (options != null)
                return LinkManager.GetItemUrl(item, options);

            return LinkManager.GetItemUrl(item);
        }
    }
}