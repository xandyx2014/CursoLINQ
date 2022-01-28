using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10_Conjunto
{
    public class IntersectDemo
    {
        public static void Ejemplo()
        {
            var personasA = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            var personasB = new List<Persona>()
                                {
                                    new Persona{Nombre = "Fernando", Edad = 25},
                                    new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                                };

            int[] A = { 1, 2, 3 };

            int[] B = { 1, 15 };
            // Interseccion es buscar los elementos comunes
            var numerosQueEstanEnAyB = A.Intersect(B);

            var personasBNombres = personasB.Select(x => x.Nombre);
            // busca los elementos comunes por nombre
            var personasQueEstanEnAyB = personasA.IntersectBy(personasBNombres, x => x.Nombre);

        }
    }
}
