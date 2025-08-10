using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MINIPROJECTASPNETCOREMVC.Controllers
{
    public class PersonController : Controller
    {
        //Misconception
        //MVC is a 3 layer application
        // UI , BUSINESSLOGIC, DATAACCESS, IT GOT 3 PARTS, MODEL VIEW CONTROLLER
        // NO: MVC IS THE USER INTERFACE LAYER, THAT'S ALL IT IS IT'S JUST THE USER INTERFACE
        // MODELS IS FOR UI, SEPRATE. MVVM - UI
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }

            try
            {
                return RedirectToAction(nameof( Index));
            }
            catch
            {
                return View();
            }
        }
    
    }
}
