using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Scdev.Web.Models
{
    [SitecoreType(TemplateId = "{383598F9-6A45-491C-BFDF-22E58F9DE56E}", AutoMap =true)]
    public interface IAboutViewModel:IGlassBase
    {
        string Title { get; set; }
        string Sub_Title { get; set; }
        string Description { get; set; }
        Image Image { get; set; }
        Link Call_To_Action { get; set; }

    }
}