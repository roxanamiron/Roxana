using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL
{
    public class UserService : IUser
    {
        #region Attributes

        private readonly UserRepository _userRepository;

        #endregion Attributes

        #region Constructor 

        public UserService( UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion Constructor

        #region PublicMethod

        public void Delete(UserEntity entity)
        {
            if (entity.Id != 0)
            {
                _userRepository.Delete(entity.Id);
            }
            else
            {
                throw new Exception("Nothing to delete!");
            }
        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }

        public void Save(UserEntity entity)
        {
            if (entity.Id == 0)
            {
                _userRepository.Insert(entity);
            }
            else
            {
                _userRepository.Update(entity);
            }
        }

        #endregion PublicMethod

        #region PrivateMethod

        private static User ConvertToEntity(UserEntity entity)
        {
            var userEntity = new User
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                UserName = entity.UserName,
                Password = entity.Password,
                
            };

            return userEntity;
        }
        #endregion PrivateMethod
    }
}
