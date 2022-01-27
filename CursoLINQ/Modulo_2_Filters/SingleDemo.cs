using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2_Filters
{
    public class SingleDemo
    {
        public static void Ejemplo()
        {

            var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};
            // se fija si el error es solo 1 elemento
            // si este tiene mas de 1 elemento arroja un error
            var personasMayorDe60 = personas.Single(p => p.Edad > 60);
            // lo mismo para SingleOrDefault lanza un nullo si no tiene solamente 1 
            // Sintaxis de queries
            var personaMayorDe60_2 = (from p in personas
                                      where p.Edad > 60
                                      select p).Single();

            try
            {
                var personaMayorA100 = personas.Single(p => p.Edad > 100);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hubo un error, arreglo vacío ${ex.Message}");
            }

            try
            {
                var personaMayor5 = personas.SingleOrDefault(p => p.Edad > 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hubo otro error, arreglo con mas de un elemento {ex.Message}");
            }

        }
    }
}
