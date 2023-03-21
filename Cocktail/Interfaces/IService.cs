using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Interfaces
{
    /// <summary>
    /// This interface can be implemented for any services that should handle CRUD data
    /// </summary>
    /// <typeparam name="T">Whatever object you want (should match the object used to get your CRUD data)</typeparam>
    public interface IService<T>
    {
        ICollection<T> GetAll();
        T GetById(int id);
        void AddItem(T item);
        void Update(int id, T item);
        void Delete(int id);
    }
}
