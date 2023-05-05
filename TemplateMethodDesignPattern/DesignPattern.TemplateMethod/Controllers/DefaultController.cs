using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlan()
        {
            NetflixPlans netflixPlans = new BasicPlan();

            ViewBag.type = netflixPlans.PlanType("Temel Plan");
            ViewBag.person = netflixPlans.CountPerson(1);
            ViewBag.price = netflixPlans.Price(65.99);
            ViewBag.content = netflixPlans.Content("Film-Dizi");
            ViewBag.resolution = netflixPlans.Resolution("480px");

            return View();
        }

        public IActionResult StandardPlan()
        {
            NetflixPlans netflixPlans = new StandardPlan();

            ViewBag.type = netflixPlans.PlanType("Standart Plan");
            ViewBag.person = netflixPlans.CountPerson(2);
            ViewBag.price = netflixPlans.Price(94.99);
            ViewBag.contenet = netflixPlans.Content("Film-Dizi-Animasyon");
            ViewBag.resolution = netflixPlans.Resolution("720px");
            
            return View();
        }

        public IActionResult UltraPlan()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            
            ViewBag.type = netflixPlans.PlanType("Ultra Plan");
            ViewBag.person = netflixPlans.CountPerson(4);
            ViewBag.price = netflixPlans.Price(134.99);
            ViewBag.content = netflixPlans.Content("Film-Dizi-Animasyon-Belgesel");
            ViewBag.resolution = netflixPlans.Resolution("1080px");

            return View();
        }
    }
}