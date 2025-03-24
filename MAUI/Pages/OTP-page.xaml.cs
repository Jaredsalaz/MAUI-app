using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace MAUI.Pages
{
    public partial class OTPPage : ContentPage
    {
        private int _timerCount = 59;

        public OTPPage()
        {
            InitializeComponent();
            StartTimer();
        }

        private async void OnVerifyClicked(object sender, EventArgs e)
        {
            // Lógica para verificar el OTP
            string otp = $"{OtpEntry1.Text}{OtpEntry2.Text}{OtpEntry3.Text}{OtpEntry4.Text}{OtpEntry5.Text}{OtpEntry6.Text}";
            if (otp == "123456") // Ejemplo de verificación
            {
                await DisplayAlert("Verificación Exitosa", "El OTP es correcto.", "OK");
            }
            else
            {
                await DisplayAlert("Error", "El OTP es incorrecto.", "OK");
            }
        }

        private async void OnResendClicked(object sender, EventArgs e)
        {
            // Lógica para reenviar el OTP
            await DisplayAlert("OTP Reenviado", "El OTP ha sido reenviado a su número registrado.", "OK");
            _timerCount = 59;
            StartTimer();
        }

        private void StartTimer()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                _timerCount--;
                TimerLabel.Text = $"0:{_timerCount:D2}s";
                if (_timerCount == 0)
                {
                    TimerLabel.Text = "Reenviar OTP";
                    return false;
                }
                return true;
            });
        }
    }
}