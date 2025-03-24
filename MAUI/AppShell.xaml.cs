using Microsoft.Maui.Controls;

namespace MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar rutas
            Routing.RegisterRoute(nameof(Pages.WelcomePage), typeof(Pages.WelcomePage));
            Routing.RegisterRoute(nameof(Pages.LoginPage), typeof(Pages.LoginPage));
            Routing.RegisterRoute(nameof(Pages.RegisterPage), typeof(Pages.RegisterPage));

            // Establecer la página inicial como WelcomePage
            CurrentItem = new ShellContent
            {
                Content = new Pages.WelcomePage()
            };
        }
    }
}