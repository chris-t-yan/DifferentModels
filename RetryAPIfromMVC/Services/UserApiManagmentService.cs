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
    public class UserApiManagmentService : BaseApiService, IApiManagmentService<Models.User>
    {
        private const string BASE_API_URL = "https://localhost:44356/api/TestApi/";
        private const string BEARER_TOKEN = "jwt token here";

        public List<User> GetAll()
        {
            return SendRequest<string, List<User>>($"{BASE_API_URL}/GetUser", string.Empty, HttpMethod.Get, new AuthenticationHeaderValue("Basic", BEARER_TOKEN));
        }

        public User Create(User entity)
        {
            return SendRequest<User, User>($"{BASE_API_URL}/post", entity, HttpMethod.Post, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }

        public User Delete(int id)
        {
            return SendRequest<int, User>($"{BASE_API_URL}/delete", id, HttpMethod.Delete, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }

       

        public User Update(User entity)
        {
            return SendRequest<User, User>($"{BASE_API_URL}/put", entity, HttpMethod.Put, new AuthenticationHeaderValue("Bearer", BEARER_TOKEN));
        }
    }
}
