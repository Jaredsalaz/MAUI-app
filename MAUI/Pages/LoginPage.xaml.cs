using Microsoft.Maui.Controls;

namespace MAUI.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para retroceder
            await Navigation.PopAsync();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Lógica para iniciar sesión
        }

        private void OnTogglePasswordVisibility(object sender, EventArgs e)
        {
            // Lógica para mostrar/ocultar la contraseña
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        }
    }
}