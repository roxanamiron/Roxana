using System.Collections.Generic;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.Repository.Ports
{
  public interface IRepository<T> where T : class
    {
        T GetById(int id);

        List<T> GetAll();

        int Insert(T entity);

        void Update(T entity);

        void SaveChanges();

        bool Delete(int id);

        void Remove(TaskEntity entity);     

        void Remove(CategoryToDoListEntity category);
        
    }
}
