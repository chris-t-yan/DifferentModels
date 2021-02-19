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
    public class PizzaApiManagmentService : BaseApiService, IApiManagmentService<Models.Pizza>
    {
        private const string BASE_API_URL = "https://localhost:44356/api/TestApi/";
        private const string BEARER_TOKEN = "jwt token here";

        public List<Pizza> GetAll()
        {
            return SendRequest<string, List<Pizza>>($"{BASE_API_URL}/GetPizza", string.Empty, HttpMethod.Get, new AuthenticationHeaderValue("Basic", BEARER_TOKEN));
        }

        public Pizza Create(Pizza entity)
        {
            return SendRequest<Pizza, Pizza>($"{BASE_API_URL}/post", entity, HttpMethod.Post, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }

        public Pizza Delete(int id)
        {
            return SendRequest<int, Pizza>($"{BASE_API_URL}/delete", id, HttpMethod.Delete, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }



        public Pizza Update(Pizza entity)
        {
            return SendRequest<Pizza, Pizza>($"{BASE_API_URL}/put", entity, HttpMethod.Put, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }
    }
}
