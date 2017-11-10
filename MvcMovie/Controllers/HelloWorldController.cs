using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// GET : /HelloWorld/
        /// Action par défaut du controller HelloWorld
        /// L'action par défaut est toujours valorisé par la méthode Index()
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        // NB : Pas de surcharge possible des Actions

        /*
        /// <summary>
        /// Action Welcome simple
        /// GET : /HelloWorld/Welcome
        /// </summary>
        /// <returns>HTML</returns>
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        /// <summary>
        /// Action Welcome avec une query string.
        /// Utilise une Query string
        /// GET : /HelloWorld/Welcome?name=Marc&numTimes=10
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="numTimes">Numerique</param>
        /// <returns>HTML</returns>
        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTime is: " + numTimes);
        }

        /// <summary>
        /// Action Welcome avec un paramètre id et une query string
        /// GET : /HelloWorld/Welcome/3?name=Toto
        /// </summary>
        /// <param name="name">query string</param>
        /// <param name="id">Identifiant</param>
        /// <returns>HTML</returns>
        public string Welcome(string name, int id = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + id);
        }
        */

        /// <summary>
        /// Action Welcome avec un paramètre name et numTimes.
        /// GET : /HelloWorld/Welcome/MarkAttack/51
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numTimes"></param>
        /// <returns></returns>
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}