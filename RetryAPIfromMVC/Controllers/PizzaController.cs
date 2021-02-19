using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetryAPIfromMVC.Interfaces;
using RetryAPIfromMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetryAPIfromMVC.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IApiManagmentService<Pizza> _pizzaApiManagmentService;
        public PizzaController(IApiManagmentService<Pizza> pizzaApiManagmentService)
        {
            _pizzaApiManagmentService = pizzaApiManagmentService;
        }
        // GET: PizzaController
        public ActionResult Index()
        {
            return View(_pizzaApiManagmentService.GetAll());
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            return View(_pizzaApiManagmentService.GetAll().FirstOrDefault(x => x.PizzaId == id));
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza)
        {
            try
            {
                _pizzaApiManagmentService.Create(pizza);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_pizzaApiManagmentService.GetAll().FirstOrDefault(x => x.PizzaId == id));
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pizza pizza)
        {
            try
            {
                _pizzaApiManagmentService.Update(pizza);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Pizza pizza)
        {
            try
            {
                _pizzaApiManagmentService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
