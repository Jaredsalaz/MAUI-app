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
        }

        private void LoadEspecialidades()
        {
            // Lista de especialidades
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

            // Enlazar la lista al CollectionView
            EspecialidadesCollectionView.ItemsSource = especialidades;
        }
    }

    // Modelo de datos para las especialidades
    public class Especialidad
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
}