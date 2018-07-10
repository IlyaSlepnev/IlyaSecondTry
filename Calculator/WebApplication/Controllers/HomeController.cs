using System.Web.Mvc;
using Calculator.twoArguments;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "SolutionMulti", Text ="Multi"
                },
                new SelectListItem()
                {
                    Value = "SolutionPlus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "SolutionMinus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "SolutionDiv", Text ="Div"
                }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(double firstArgument, double secondArgument, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument, secondArgument);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "SolutionMulti", Text ="Multi"
                },
                new SelectListItem()
                {
                    Value = "SolutionPlus", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "SolutionMinus", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "SolutionDiv", Text ="Div"
                }
            };
            return View();
        }
    }
}