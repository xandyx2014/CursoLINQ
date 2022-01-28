using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_5_Scalars
{
    public class SumMaxMin
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

            Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
            // se puede pasar un predicate en el Sum
            Console.WriteLine($"La suma de los numeros es {personas.Sum(p => p.Edad)}");
            // se puede pasar un predicate en el Sum
            Console.WriteLine($"La edad máxima de las personas es {personas.Max(x => x.Edad)}");
            Console.WriteLine($"La edad mínima de las personas es {personas.Min(x => x.Edad)}");
        }
    }
}
