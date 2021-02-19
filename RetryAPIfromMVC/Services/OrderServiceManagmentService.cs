using RetryAPIfromMVC.Interfaces;
using RetryAPIfromMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RetryAPIfromMVC.Services
{
    public class OrderApiManagmentService : BaseApiService, IApiManagmentService<Models.Order>
    {
        private const string BASE_API_URL = "https://localhost:44356/api/TestApi";
        private const string BEARER_TOKEN = "jwt token here";

        public List<Order> GetAll()
        {
            return SendRequest<string, List<Order>>($"{BASE_API_URL}/GetOrders", string.Empty, HttpMethod.Get, new AuthenticationHeaderValue("Basic", BEARER_TOKEN));
        }

        public Order Create(Order entity)
        {
            return SendRequest<Order, Order>($"{BASE_API_URL}/post", entity, HttpMethod.Post, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }

        public Order Delete(int id)
        {
            return SendRequest<int, Order>($"{BASE_API_URL}/delete", id, HttpMethod.Delete, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }



        public Order Update(Order entity)
        {
            return SendRequest<Order, Order>($"{BASE_API_URL}/put", entity, HttpMethod.Put, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }
    }
}
