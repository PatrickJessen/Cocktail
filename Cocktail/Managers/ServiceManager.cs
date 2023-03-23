using Cocktail.Interfaces;
using Cocktail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Managers
{
    public class ServiceManager<T>
    {
        private IService<T> service;

        public ServiceManager(IService<T> service)
        {
            this.service = service;
        }

        public void AddItem(T item)
        {
            service.AddItem(item);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

        public ICollection<T> GetAll()
        {
            return service.GetAll();
        }

        public T GetById(int id)
        {
            return service.GetById(id);
        }

        public void Update(int id, T item)
        {
            service.Update(id, item);
        }
    }
}
