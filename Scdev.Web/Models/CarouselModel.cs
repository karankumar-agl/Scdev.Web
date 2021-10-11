using System.Collections.Generic;
using System.Web.Mvc;

namespace Scdev.Web.Models
{
    public class CarouselModel
    {
        public List<Slide> Slides { get; set; }
    }
    public class Slide
    {
        public MvcHtmlString Title { get; set; }
        public MvcHtmlString SubTitle { get; set; }
        public MvcHtmlString Image { get; set; }
        public MvcHtmlString CallToAction { get; set; }
    }
}