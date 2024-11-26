using StefanJativa_MAUI.Repositories;

namespace StefanJativa_MAUI;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();

		EstudentUdlaRepository estudentUdlaRepository = new EstudentUdlaRepository();
		var info_estudiante = estudentUdlaRepository.DevuelveInfoEstudiante();

        id.Text = info_estudiante.Id.ToString(); // Corrige a "id"
        nombre.Text = info_estudiante.Nombre;   // Corrige a "nombre"
        carrera.Text = info_estudiante.Carrera; // Corrige a "carrera"
    }
}