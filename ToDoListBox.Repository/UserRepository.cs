using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.Repository.Entity;
using ToDoListBox.Repository.Ports;

namespace ToDoListBox.Repository
{
   public class UserRepository : Repository<UserEntity>
    {
        #region Constructor 

        public UserRepository()
        {
            //_userRepository = userRepository;
        }
        #endregion Constructor

        public UserEntity GetUserById(int id)
        {
            return GetById(id);
        }

        public List<UserEntity> GetAllUser()
        {
            return GetAll();
        }

        public int InsertEntity (UserEntity entity)
        {
            return Insert(entity);
        }

        public void UpdateEntity (UserEntity entity)
        {
            Update(entity); 
        }

        public bool DeleteEntity(int id)
        {
            return Delete(id);
        }

        public override void Remove(CategoryToDoListEntity category)
        {
            throw new NotImplementedException();
        }       
    }
}
