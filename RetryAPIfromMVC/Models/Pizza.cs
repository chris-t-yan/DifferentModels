using RetryAPIfromMVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetryAPIfromMVC.Models
{
    public class Pizza 
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public double Price { get; set; }
      
    }
}