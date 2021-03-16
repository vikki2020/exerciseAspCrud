using exerciseAsp.DAL;
using exerciseAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exerciseAsp.Controllers
{
    public class DogsController : Controller
    {
        //Import DogDAL
        DogDAL db = new DogDAL();


        // GET: Dogs
        public ActionResult Index()
        {
            return View();
        }

        //GET:Dogs/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST:Dogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DogClass dog)
        {
            if (ModelState.IsValid)
            { //Insert the form info to db
                db.CreateDog(dog);

                return RedirectToAction("Index");
            }
            return View(dog);
               
        }

        //if the model state is not valid
        

    }
}