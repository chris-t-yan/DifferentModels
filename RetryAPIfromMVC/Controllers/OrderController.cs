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
    public class OrderController : Controller
    {

        private readonly IApiManagmentService<Order> _orderApiManagmentService;
        public OrderController(IApiManagmentService<Order> orderApiManagmentService)
        {
            _orderApiManagmentService = orderApiManagmentService;
        }
        //GET: OrderController

        public ActionResult Index()
        {
            return View(_orderApiManagmentService.GetAll());
        }
        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View(_orderApiManagmentService.GetAll().FirstOrDefault(x => x.OrderId == id));
        }

        // GET: OrderController/CreHomeController.csate
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            try
            {
                _orderApiManagmentService.Create(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_orderApiManagmentService.GetAll().FirstOrDefault(x => x.OrderId == id));
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order)
        {
            try
            {
                _orderApiManagmentService.Update(order);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order order)
        {
            try
            {
                _orderApiManagmentService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    
}
