using Microsoft.Maui.Controls;

namespace MAUI.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

           
            bool isAuthenticated = await AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // Navegar a la página principal de la aplicación
                await Shell.Current.GoToAsync("//Appointments");
            }
            else
            {
                await DisplayAlert("Error", "Invalid username or password", "OK");
            }
        }

        private Task<bool> AuthenticateUser(string username, string password)
        {
            // Implementa la lógica de autenticación aquí
            return Task.FromResult(username == "admin" && password == "password");
        }
    }
}