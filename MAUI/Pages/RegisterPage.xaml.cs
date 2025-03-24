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
            // Lógica para el registro
        }

        private async void OnTermsOfUseTapped(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.example.com/terms");
        }

        private async void OnPrivacyPolicyTapped(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.example.com/privacy");
        }
    }
}