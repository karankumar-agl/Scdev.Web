using Sitecore;
using Sitecore.Buckets.Managers;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Pipelines.HttpRequest;
using System.Linq;

namespace Scdev.Web.CustomCode
{
    public class CustomItemResolver : HttpRequestProcessor
    {
        public override void Process(HttpRequestArgs args)
        {
           if(Context.Item==null)
            {
                var requestUrl = args.Url.ItemPath;
                var index = requestUrl.LastIndexOf('/');
                if (index > 0)
                {
                    var bucketPath = requestUrl.Substring(0, index);
                    var bucketItem = args.GetItem(bucketPath);
                    if (bucketItem != null && BucketManager.IsBucket(bucketItem))
                    {
                        var itemName = requestUrl.Substring(index + 1).Replace("-", " ");

                        using (var searchContext = ContentSearchManager.GetIndex("sitecore_web_index")
                            .CreateSearchContext())
                        {
                            var result = searchContext.GetQueryable<SearchResultItem>().
                                Where(x => x.Name == itemName 
                               // && x.TemplateId == new Sitecore.Data.ID("{54004F63-BAB7-4896-9CDC-C1BF4DEEF921}")
                               )
                                .FirstOrDefault();
                            if (result != null)
                                Context.Item = result.GetItem();
                        }
                    }
                }
            }
        }
    }
}