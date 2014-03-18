using DataAccess.Repository;
using DataAccessAbstraction;
using DataAccessAbstraction.Entities;
using DataAccessAbstraction.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            TagCollectionViewModel model = new TagCollectionViewModel();
            ITagRepository repository = new TagRepository(ConfigurationManager.AppSettings["RootDatabaseConnectionString"]);
            IOperationResponse<List<ITag>> response = repository.GetAllPredefinedTags();
            if (response.Value != null)
            {
                 model = new TagCollectionViewModel(response.Value);
            }

            return View(model);
        }

    }
}
