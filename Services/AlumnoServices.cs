using Poo_Estructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Estructura.Services
{
    public class AlumnoServices
    {
        public Alumno Agregar()
        {
            try {
                Alumno res = new Alumno()
                {
                    Id = 1,
                    Nombre = "Victor",
                    Apellido = "Salgado",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 9.5
                };
                return res;
            } 
            catch (Exception ex) {
                throw new Exception("Sucedio un error"+ex.Message)
            }
        }
    }
}
