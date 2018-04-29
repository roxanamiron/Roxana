using ToDoListBox.Repository.Entity;

namespace ToDoListBox.BLL.Ports
{
    public interface IUser
    {
        void Save(UserEntity entity);

        void Delete(UserEntity entity);        
    }
}
