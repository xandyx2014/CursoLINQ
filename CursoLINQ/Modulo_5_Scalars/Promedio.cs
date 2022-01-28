using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_5_Scalars
{
    public class Promedio
    {
        public static void Ejemplo()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", Edad = 19, },
                            new Persona { Nombre = "Nidia", Edad = 25 },
                            new Persona { Nombre = "Alejandro", Edad = 30 },
                            new Persona { Nombre = "Valentina", Edad = 22 }
                            };

            var numeros = Enumerable.Range(1, 5);
            // Average es el promedio 
            Console.WriteLine($"El promedio de los números es {numeros.Average()}");
            // Average es el promedio de las persona en la edad
            Console.WriteLine($"El promedio de las edades es {personas.Average(p => p.Edad)}");

        }
    }
}
