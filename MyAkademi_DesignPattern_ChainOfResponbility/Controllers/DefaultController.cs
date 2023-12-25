using Microsoft.AspNetCore.Mvc;
using MyAkademi_DesignPattern_ChainOfResponbility.ChainOfResponbility;
using MyAkademi_DesignPattern_ChainOfResponbility.Models;

namespace MyAkademi_DesignPattern_ChainOfResponbility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(CustomerProcessViewModel model) 
        { 
            Employee treasurer=new Treasurer();
            Employee managerAssistant=new ManagerAssistant();
            Employee manager=new Manager();
            Employee areaDirector=new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);

            return View(); 
        }
    }
}
