using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.Repository.Entity;
using ToDoListBox.Repository.Ports;

namespace ToDoListBox.Repository
{
    public class UserToDosRepository : Repository<UserToDosEntity>
    {
        #region Constructor 

        public UserToDosRepository()
        {
            //_userToDosRepository = userToDosRepository;
        }
        #endregion Constructor

        public UserToDosEntity GetUserToDosById(int id)
        {
            return GetById(id);
        }

        public List<UserToDosEntity> GetAllUserToDos()
        {
            return GetAll();
        }

        public int InsertUserToDos(UserToDosEntity entity)
        {
            return Insert(entity);
        }

        public void UpdateUserToDos(UserToDosEntity entity)
        {
            Update(entity);
        }

        public bool Delete(int id)
        {
            return Delete(id);
        }

        public object GetUserToDosList()
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryToDoListEntity category)
        {
            throw new NotImplementedException();
        }  
    }
}
