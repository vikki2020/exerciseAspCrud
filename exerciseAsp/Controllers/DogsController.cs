using exerciseAsp.DAL;
using exerciseAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            //Return a list of all the dogs from the db
            List<DogClass> myList = new List<DogClass>();
            myList = db.ListDogs().ToList();
            return View(myList);
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

            //if the model state is not valid
            return View(dog);
               
        }

        // GET:Workers/Details/2
        public ActionResult Details(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //check if the worker exist in db
            DogClass dog = db.ReadOne(id);
            if(dog==null)
            {
                return HttpNotFound();
            }
            return View(dog);
        }

        // GET:Workers/Delete/3
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //check if the worker exist in db
            DogClass dog = db.ReadOne(id);
            if (dog == null)
            {
                return HttpNotFound();
            }
            return View(dog);
        }

        //POST:Workers/Delete/3
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           
                db.DeleteDog(id);

                return RedirectToAction("Index");
            
        }

        // GET:Workers/Edit/4
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //check if the worker exist in db
            DogClass dog = db.ReadOne(id);
            if (dog == null)
            {
                return HttpNotFound();
            }
            return View(dog);
        }

        //POST:Workers/Edit/4
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DogClass dog)
        {
            if(ModelState.IsValid)
            {
                //update db
                db.UpdateDog(dog);
                return RedirectToAction("Index");
            }
            //if the model state is not valid
            return View(dog);
            

          

        }


    }
}