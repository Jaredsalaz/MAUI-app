using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MAUI.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            LoadEspecialidades();
            LoadDoctores();
        }

        private void LoadEspecialidades()
        {
            var especialidades = new List<Especialidad>
            {
                new Especialidad { Nombre = "General", Imagen = "general.png" },
                new Especialidad { Nombre = "Nefrólogo", Imagen = "nefrologo.png" },
                new Especialidad { Nombre = "Cardiólogo", Imagen = "cardiologo.png" },
                new Especialidad { Nombre = "Neurólogo", Imagen = "neurologo.png" },
                new Especialidad { Nombre = "Dentista", Imagen = "dentista.png" },
                new Especialidad { Nombre = "Ginecólogo", Imagen = "ginecologo.png" },
                new Especialidad { Nombre = "Pediatra", Imagen = "pediatra.png" },
                new Especialidad { Nombre = "Cirujano", Imagen = "cirujano.png" }
            };

            EspecialidadesCollectionView.ItemsSource = especialidades;
        }

        private void LoadDoctores()
        {
            var doctores = new List<Doctor>
            {
                new Doctor { Nombre = "Dr Alondra Martinez", Imagen = "doctor1.png", Rating = "4.5", Especialidad = "Cardiólogo", Experiencia = "42 Años Experiencia", Ubicacion = "Hospital San Lucas, Carretera Villaflores" },
                new Doctor { Nombre = "Dr Juan Perez", Imagen = "doctor2.png", Rating = "4.8", Especialidad = "Dentista", Experiencia = "15 Años Experiencia", Ubicacion = "Clínica Dental Smile, Centro" }
            };

            DoctoresCollectionView.ItemsSource = doctores;
        }
    }

    public class Especialidad
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }

    public class Doctor
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Rating { get; set; }
        public string Especialidad { get; set; }
        public string Experiencia { get; set; }
        public string Ubicacion { get; set; }
    }
}