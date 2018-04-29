using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListBox.UI.Startup))]
namespace ToDoListBox.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
