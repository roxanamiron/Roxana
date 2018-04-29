using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListBox.Repository.Entity;
using ToDoListBox.Repository.Ports;

namespace ToDoListBox.Repository
{
    public class CategoryToDoListRepository : Repository<CategoryToDoListEntity>
    {      

        #region Constructor

        public CategoryToDoListRepository()
        {
            //_categoryToDoListRepository = categoryToDoListRepository;
        }
        #endregion Constructor

        #region Public Method
        public CategoryToDoListEntity GetCategoryById (int id)
        {
            return GetById(id);
        }

        public List<CategoryToDoListEntity> GetAllCategory()
        {
            return GetAll();
        }

        public int InsertCategoryToDoList (CategoryToDoListEntity entity)
        {
            return Insert(entity);
        }

        public void UpdateCategoryToDoList (CategoryToDoListEntity entity)
        {
            Update(entity);
        }
                
        public bool Delete(CategoryToDoListEntity category)
        {           
            return true;
        }

        public override void Remove(CategoryToDoListEntity category)
        {
            throw new NotImplementedException();
        }       
        #endregion Public Method
    }
}
