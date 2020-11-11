using DHSolutionsWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DHSolutionsWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Games> gamesList;
            HttpResponseMessage response = HTTPClientSingelton.client.GetAsync("games").Result;
            gamesList = response.Content.ReadAsAsync<IEnumerable<Games>>().Result;

            return View(gamesList);
        }

        public ActionResult addEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Games());
            }
            else
            {
                HttpResponseMessage recievedData = HTTPClientSingelton.client.GetAsync("games/" + id.ToString()).Result;
                return View(recievedData.Content.ReadAsAsync<Games>().Result);
            }
            
        }

        //test 2
        [HttpPost]
        public ActionResult addEdit(Games games)
        {

            if (games.Id == 0)
            {
                HttpResponseMessage response = HTTPClientSingelton.client.PostAsJsonAsync("games", games).Result;
                return RedirectToAction("Index");
            }
            else
            {
                HttpResponseMessage response = HTTPClientSingelton.client.PutAsJsonAsync("games/" + games.Id, games).Result;
                return RedirectToAction("Index");
            }


        }

        public ActionResult remove(int id)
        {
            HttpResponseMessage response = HTTPClientSingelton.client.DeleteAsync("games/"+ id.ToString()).Result;
            return RedirectToAction("Index");
        }

        public ActionResult details(int id)
        {
            HttpResponseMessage recievedData = HTTPClientSingelton.client.GetAsync("games/" + id.ToString()).Result;
            return View(recievedData.Content.ReadAsAsync<Games>().Result);
        }
    }
}