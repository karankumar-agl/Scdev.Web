using System;
using System.Collections.Generic;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Web.Mvc;

namespace Scdev.Web.Models
{
    public class GlassBase : IGlassBase
    {
        readonly IMvcContext _context;
        public GlassBase()
        {
            _context = new MvcContext();
        }
        [SitecoreField("__created")]
        public DateTime CreatedDate { get; set; }

        [SitecoreId]
        public Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        public string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public Guid TemplateId { get; set; }

        [SitecoreField("__Updated")]
        public DateTime UpdatedDate { get; set; }

        [SitecoreField("__Display name")]
        public string DisplayName { get; set; }

        [SitecoreField("ShowInNavigation")]
        public bool ShowInNavigation { get; set; }

        [SitecoreField("ShowInSitemap")]
        public bool ShowInSitemap { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public string Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        public string FullPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        public string PageUrl { get; set; }

        [SitecoreParent]
        public IGlassBase Parent { get; set; }

        [SitecoreChildren]
        public IEnumerable<IGlassBase> Children { get; set; }

        public Dictionary<string, string> DictionaryLabels { get; set; }
    }
    public interface IGlassBase
    {
        [SitecoreField("__created")]
        DateTime CreatedDate { get; set; }

        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        [SitecoreField("__Updated")]
        DateTime UpdatedDate { get; set; }

        [SitecoreField("__Display name")]
        string DisplayName { get; set; }

        [SitecoreField("ShowInNavigation")]
        bool ShowInNavigation { get; set; }

        [SitecoreField("ShowInSitemap")]
        bool ShowInSitemap { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        string Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        string FullPath { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        string PageUrl { get; set; }

        [SitecoreParent]
        IGlassBase Parent { get; set; }

        [SitecoreChildren]
        IEnumerable<IGlassBase> Children { get; set; }

        Dictionary<string, string> DictionaryLabels { get; set; }
    }
}