using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Sites;

namespace Scdev.Web.Extensions
{
    public static class SiteExtensions
    {
        public static Item HomeItem(this SiteContext siteContext)
        {
            return Context.Database.GetItem(siteContext.StartPath);
        }
    }
}