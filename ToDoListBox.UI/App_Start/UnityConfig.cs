using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using ToDoListBox.BLL;
using ToDoListBox.BLL.Ports;
using ToDoListBox.Core.Models;
using ToDoListBox.Repository;
using ToDoListBox.Repository.Entity;
using ToDoListBox.Repository.Ports;
using ToDoListBox.UI.Controllers;
using ToDoListBox.UI.Models;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace ToDoListBox.UI
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container

        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        /// 
        public static IUnityContainer Container => container.Value;

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();


            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));

            container.RegisterType<DbContext, ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            //container.RegisterType<CategoryToDoListController>(new InjectionConstructor());
            //container.RegisterType<TaskController>(new InjectionConstructor());

            container.RegisterType<TaskRepository>("Task repository");
            container.RegisterType<ToDoListRepository>("ToDO repository");
            container.RegisterType<UserToDosRepository>("ToDOs repository");
            container.RegisterType<UserRepository>("ToDOss repository");

            container.RegisterType<ITaskService, TaskService>();
            container.RegisterType<BLL.Ports.IUser, UserService>();
            container.RegisterType<IUserToDos, UserToDosService>();
            container.RegisterType<IToDoList, ToDoListService>();
            container.RegisterType<ICategoryToDoList, CategoryToDoListService>();

            //container.RegisterType<CategoryToDoListService>("CategoryToDoListService");
            //container.RegisterType<UserService>("UserService");
            //container.RegisterType<UserToDos>("UserToDoService");
            //container.RegisterType<ToDoListService>("ToDoListService");
        }

    }
}