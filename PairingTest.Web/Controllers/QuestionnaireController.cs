using System.Web.Mvc;
using PairingTest.Web.Models;
using PairingTest.Web.Services;
using System.Threading.Tasks;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {

        /* ASYNC ACTION METHOD... IF REQUIRED... */
        public async Task<ViewResult> Index()
        {
            var result = await QuestionnaireService.Instance.GetQuestionsAsync();

            return View(result);
        }

        //public ViewResult Index()
        //{
        //    QuestionnaireViewModel model = new QuestionnaireViewModel();
        //    model.QuestionnaireTitle = "Quest";
        //    model.QuestionsText = new System.Collections.Generic.List<string>() { "Who are you?" };

        //    return View(model);
        //}

    }
}
