using Microsoft.AspNetCore.Mvc;
using RetryAPIfromMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetryAPIfromMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        // GET: api/<TestApiController>
        [HttpGet]
        public IEnumerable<User> GetUser()
        {
            List <User> users = new List<User>()
            {
                new User(){ UserId = 1, FirstName = "User", LastName = "1" },
                new User(){ UserId = 2, FirstName = "User", LastName = "2" },
                new User(){ UserId = 3, FirstName = "User", LastName = "3" },

            };
            return users;
        }
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            List<Order> orders = new List<Order>()
            {
                new Order(){ OrderId = 1, Delivered = true},
                new Order(){ OrderId = 2, Delivered = false },
                new Order(){ OrderId = 3, Delivered = true },

            };
            return orders;
        }
        [HttpGet]
        public IEnumerable<Pizza> GetPizza()
        {
            List<Pizza> pizzas = new List<Pizza>()
            {
                new Pizza(){ PizzaId = 1, PizzaName = "Kapricioza", Price = 450 },
                new Pizza(){ PizzaId = 2, PizzaName = "Margarita", Price = 400 },
                new Pizza(){ PizzaId = 3, PizzaName = "Kapri", Price = 350 },

            };
            return pizzas;
        }

        // GET api/<TestApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestApiController>
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            return Ok("OK");
        }

        // PUT api/<TestApiController>/5
        [HttpPut]
        public ActionResult Put()
        {
            return Ok("OK");
        }

        // DELETE api/<TestApiController>/5
        [HttpDelete]
        public ActionResult Delete()
        {
            return Ok("OK");
        }
    }
}
