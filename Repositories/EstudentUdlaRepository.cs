using StefanJativa_MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StefanJativa_MAUI.Repositories
{
    public class EstudentUdlaRepository
    {
        public EstudentUDLA DevuelveInfoEstudiante()
        {
            return new EstudentUDLA()
            {
                Id = 1,
                Nombre = "Santiago",
                Carrera = "Ing. Software"
            };
        }
    }
}
