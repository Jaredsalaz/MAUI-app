using Microsoft.Maui.Controls;

namespace MAUI.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // Aquí puedes añadir la lógica para registrar al usuario
            await DisplayAlert("Registro", "Usuario registrado con éxito", "OK");
        }
    }
}