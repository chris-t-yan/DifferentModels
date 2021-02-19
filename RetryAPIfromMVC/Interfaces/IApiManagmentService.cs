using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetryAPIfromMVC.Interfaces
{
    public interface IApiManagmentService<T> where T : class
    {
        List<T> GetAll();
        T Create(T entity);
        T Update(T entity);
        T Delete(int Id);


    }
}
