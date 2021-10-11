using Sitecore.Buckets.Extensions;
using Sitecore.Buckets.Managers;
using Sitecore.IO;
using Sitecore.Links;

namespace Scdev.Web.CustomCode
{
    public class CustomLinkProvider : LinkProvider
    {
        public override string GetItemUrl(Sitecore.Data.Items.Item item,
          Sitecore.Links.UrlOptions options)
        { 
            if (BucketManager.IsItemContainedWithinBucket(item))
            {
                var bucketItem = item.GetParentBucketItemOrParent();
                if (bucketItem != null && bucketItem.IsABucket())
                {
                    var bucketUrl = base.GetItemUrl(bucketItem, options);
                    return FileUtil.MakePath(bucketUrl, item.Name.Replace(' ', '-'));
                }
            }
            return base.GetItemUrl(item, options);
        }

    }
}