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
    public class UserController : Controller
    {

        private readonly IApiManagmentService<User> _userApiManagmentService;
        public UserController(IApiManagmentService<User> userApiManagmentService)
        {
            _userApiManagmentService = userApiManagmentService;
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View(_userApiManagmentService.GetAll());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View(_userApiManagmentService.GetAll().FirstOrDefault(x => x.UserId == id));
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                _userApiManagmentService.Create(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_userApiManagmentService.GetAll().FirstOrDefault(x => x.UserId == id));
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                _userApiManagmentService.Update(user);
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
            
            return View(_userApiManagmentService.GetAll().FirstOrDefault(x => x.UserId == id));
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User user)
        {
            try
            {
                _userApiManagmentService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
