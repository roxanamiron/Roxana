using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.Repository.Entity;
using ToDoListBox.Repository.Ports;

namespace ToDoListBox.Repository
{
    public class ToDoListRepository : Repository<ToDoListEntity>
    {    

        #region Constructor 

        public ToDoListRepository()
        {
            //_toDoListRepository = toDoListRepository;
        }
        #endregion Constructor

        public ToDoListEntity GetToDoListById(int id)
        {
            return GetById(id);
        }

        public List<ToDoListEntity> GetAllToDoList()
        {
            return GetAll();
        }

        public int InsertToDoLsit(ToDoListEntity entity)
        {
            return Insert(entity);
        }

        public void UpdateToDoList(ToDoListEntity entity)
        {
            Update(entity);
        }

        public bool DeleteToDoList(int id)
        {
            return Delete(id);
        }

        public void Delete(ToDoListEntity todolist)
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryToDoListEntity category)
        {
            throw new NotImplementedException();
        }        
    }
}
