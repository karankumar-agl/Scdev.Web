using Sitecore.Data.Fields;
using Scdev.Web.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Scdev.Web.Extensions;

namespace Scdev.Web.Controllers
{
    public class CarouselController : Controller
    {
        public ActionResult Index()
        {
            // var sitecoreStartPath= Sitecore.Context.Site.StartPath;
            //  var homeItem = Sitecore.Context.Database.GetItem(sitecoreStartPath);
            var homeItem=  Sitecore.Context.Site.HomeItem();
            var model = new CarouselModel();
            List<Slide> slides = new List<Slide>();

            var dataSource = RenderingContext.Current?.Rendering.Item;
            MultilistField slidesField = dataSource.Fields["Slides"];

            //Rendering Parameters
            var slideCountParam = RenderingContext.Current?.Rendering.Parameters["SlideCount"];
            int.TryParse(slideCountParam, out int result);
            int slideCount = result == 0 ? 2 : result;

            if (slidesField?.Count > 0)
            {
                var slideItems = slidesField.GetItems();

                foreach(var slideItem in slideItems.Take(slideCount))
                {
                    //Title
                    //var titleField = slideItem.Fields["Title"];
                    //var title = titleField?.Value;
                   
                    var title = new MvcHtmlString(FieldRenderer.Render
                        (slideItem, "Title"));

                    //Sub Title
                    var subTitle = new MvcHtmlString(FieldRenderer.Render
                        (slideItem, "Sub_Title"));

                    //Image
                    var image = new MvcHtmlString(FieldRenderer.Render
                        (slideItem, "Image"));

                    //Call to action
                    var callToAction = new MvcHtmlString(FieldRenderer.Render
                        (slideItem, "Call_To_Action", "class=btn animated fadeInUp"));

                    slides.Add(new Slide
                    {
                        Title = title,
                        SubTitle = subTitle,
                        Image = image,
                        CallToAction = callToAction
                    });
                }
                model.Slides = slides;
            }
            return View(model);
        }
    }
}