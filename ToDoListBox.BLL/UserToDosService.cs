using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL
{
    public class UserToDosService : IUserToDos

    {
        #region Attributes

        private readonly UserToDosRepository _userToDosRepository;

        #endregion Attributes

        #region Constructor

        public UserToDosService(UserToDosRepository userToDosRepository)
        {
            userToDosRepository = _userToDosRepository;
        }

        #endregion Constructor

        public void Delete(UserToDosEntity userToDosEntity)
        {
            if (userToDosEntity.Id != 0)
            {
                _userToDosRepository.Delete(userToDosEntity.Id);
            }
            else
            {
                throw new Exception("Nothing to delete!");
            }
        }

        public List<UserToDos> GetUserToDosList()
        {
            var userToDosList = new List<UserToDos>();
            var userToDosEntity = _userToDosRepository.GetUserToDosList();
            userToDosList = Mapper.Map<List<UserToDos>>(userToDosEntity);

            return userToDosList;
        }

        public void Save(UserToDosEntity userToDosEntity)
        {
            if (userToDosEntity.Id == 0)
            {
                _userToDosRepository.Insert(userToDosEntity);
            }
            else
            {
                _userToDosRepository.Update(userToDosEntity);
            }
        }
    }
}
