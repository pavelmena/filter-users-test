using Models;
using Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientService _clientService;
        public HomeController(IClientService clientService)
        {
            _clientService = clientService;
        }

        /// <summary>
        /// Default home index was alter in order to display the Client's list.
        /// </summary>
        /// <param name="type">Filter clients by type.</param>
        /// <returns></returns>
        public ActionResult Index(TypeEnum? type)
        {
            // Enhance this code using automapper.
            // Also add control for which clients are selected in the View layer once 
            // defined for which we are selecting more than one client.
            var model = new HomeVM
            {
                AvailableClients = _clientService.GetClients(type)
            };

            return View(model);
        }

        /// <summary>
        /// Method that must to be added into a new ClientController item.
        /// </summary>
        /// <param name="id">Id of the client to edit</param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            // #TODO
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Method that must to be added into a new ClientController item.
        /// </summary>
        /// <param name="id">Id of the client to display details</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            // #TODO
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Method that must to be added into a new ClientController item.
        /// </summary>
        /// <param name="id">Id of the client to delete</param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            // #TODO
            return RedirectToAction("Index");
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
    }
}