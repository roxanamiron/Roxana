using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.Core.Models;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Repository;
using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL
{
    public class ToDoListService : IToDoList
    {
        #region Attributes

        private readonly ToDoListRepository _toDoListRepository;

        #endregion Attributes

        #region Constructor

        public ToDoListService(ToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        #endregion Constructor 

        #region Public Methods

        public ToDoListEntity GetToDoListById(int id)
        {
            return _toDoListRepository.GetById(id);
        }     

        public void Save(ToDoListEntity toDoListEntity)
        {
            if (toDoListEntity.Id == 0)
            {
                _toDoListRepository.Insert(toDoListEntity);
            }
            else
            {
                _toDoListRepository.Update(toDoListEntity);
            }
        }

        public void Delete(ToDoListEntity toDoListEntity)
        {
            if (toDoListEntity.Id == 0)
            {
                throw new Exception("Select a todolist to delete");
            }
            var todolist = _toDoListRepository.GetById(toDoListEntity.Id);
            var todolistid = todolist.CategoryId;

            _toDoListRepository.Delete(todolist);
        }

        public List<ToDoList> GetToDoList()
        {
            throw new NotImplementedException();
        }

        #endregion Public Methods        
    }
}
