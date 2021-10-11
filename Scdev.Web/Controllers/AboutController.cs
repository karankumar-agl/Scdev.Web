using Glass.Mapper.Sc.Web.Mvc;
using Scdev.Web.Models;
using System.Web.Mvc;

namespace Scdev.Web.Controllers
{
    public class AboutController : Controller
    {       
        public ActionResult Index()
        {
            IMvcContext mvcContext = new MvcContext();
            var model = mvcContext.GetDataSourceItem<IAboutViewModel>();        
            return View(model);
        }
    }
}