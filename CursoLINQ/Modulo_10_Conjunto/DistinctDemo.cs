using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10_Conjunto
{
    public class DistinctDemo
    {
        public static void Ejemplo()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Eduardo"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            int[] numeros = { 1, 2, 3, 1, 1, 6 };
            // devuelve los elementos no repetidos
            var numerosSinRepeticiones = numeros.Distinct();
            // entra a los personas distintas segun su nombre
            var personasSinNombresRepetidos = personas.DistinctBy(x => x.Nombre);

            // Sintaxis de queries
            var numerosSinRepeticiones_2 = from n in numeros.Distinct()
                                           select n;

            var personasSinNombresRepetidos_2 = from p in personas.DistinctBy(x => x.Nombre)
                                                select p;
        }
    }
}
