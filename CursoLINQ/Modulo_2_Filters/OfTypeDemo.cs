using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_2_Filters
{
    public class OfTypeDemo
    {
        public static void Ejemplo()
        {
            var listado = new List<object>() { "Felipe", 1, 2, "Claudia", true };
            // obtiene solamente los string
            var strings = listado.OfType<string>();
            // obtiene solamente los int
            var numeros = listado.OfType<int>();

            // sintaxis de queries
            var strings_2 = from s in listado.OfType<string>()
                            select s;

            // Ejemplo 2: herencia

            var listadoAnimales = new List<Animal>()
                                    {
                                        new Perro(){Nombre = "Firulais"},
                                        new Gato(){Nombre = "Félix"}
                                    };
            // Obtiene solamente Los perros
            var perros = listadoAnimales.OfType<Perro>();
        }

        public abstract class Animal
        {
            public abstract string? Nombre { get; set; }
        }

        public class Perro : Animal
        {
            public override string? Nombre { get; set; }
        }

        public class Gato : Animal
        {
            public override string? Nombre { get; set; }
        }
    }
}
