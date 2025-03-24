using Microsoft.Maui.Controls;

namespace MAUI.Pages
{
    public partial class SetPasswordPage : ContentPage
    {
        public SetPasswordPage()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para retroceder
            await Navigation.PopAsync();
        }

        private void OnTogglePasswordVisibility(object sender, EventArgs e)
        {
            // Lógica para mostrar/ocultar la contraseña
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
        }

        private void OnToggleConfirmPasswordVisibility(object sender, EventArgs e)
        {
            // Lógica para mostrar/ocultar la confirmación de contraseña
            ConfirmPasswordEntry.IsPassword = !ConfirmPasswordEntry.IsPassword;
        }

        private async void OnCreatePasswordClicked(object sender, EventArgs e)
        {
            // Lógica para crear una nueva contraseña
            // Aquí puedes agregar la lógica para validar y guardar la nueva contraseña
            await DisplayAlert("Contraseña Creada", "Tu contraseña ha sido creada exitosamente.", "OK");
        }
    }
}