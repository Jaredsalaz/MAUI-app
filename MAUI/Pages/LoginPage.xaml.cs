using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage; // Para SecureStorage

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
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(UsernameEntry.Text))
            {
                await DisplayAlert("Error", "Ingresa tu correo o número telefónico", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordEntry.Text))
            {
                await DisplayAlert("Error", "Ingresa tu contraseña", "OK");
                return;
            }

            // Deshabilitar botón durante la autenticación
            if (sender is Button btn) btn.IsEnabled = false;

            try
            {
                bool isAuthenticated = await AuthenticateUser(UsernameEntry.Text, PasswordEntry.Text);

                if (isAuthenticated)
                {
                    // Guardar token de sesión (ejemplo)
                    await SecureStorage.SetAsync("auth_token", "token_simulado");

                    // Navegar a página principal
                    await Shell.Current.GoToAsync("//Appointments");
                }
                else
                {
                    await DisplayAlert("Error", "Credenciales incorrectas", "OK");
                    PasswordEntry.Text = string.Empty; // Limpiar campo
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Error: {ex.Message}", "OK");
            }
            finally
            {
                if (sender is Button loginButton) loginButton.IsEnabled = true;
            }
        }

        private async Task<bool> AuthenticateUser(string username, string password)
        {
            // Simular retraso de red
            await Task.Delay(1000);

            // En un caso real, aquí iría una llamada a API:
            // return await AuthService.Login(username, password);
            
            return username == "admin" && password == "password"; // Demo
        }

        private void OnTogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
            
            // Cambiar icono dinámicamente (requiere tener dos imágenes)
            if (sender is ImageButton imgBtn)
            {
                imgBtn.Source = PasswordEntry.IsPassword 
                    ? "eye_closed_icon.png" 
                    : "eye_open_icon.png";
            }
        }
    }
}