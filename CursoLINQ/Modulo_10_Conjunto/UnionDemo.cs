using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10_Conjunto
{
    public class UnionDemo
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

            int[] numerosA = { 1, 2, 3, 1, 1, 6 };

            int[] numerosB = { 1, 2, 15 };
            // une las coleecion y elimina los duplicados
            var unionDeNumeros = numerosA.Union(numerosB);
            // une las colleciones y elimina los duplicados por Nombre
            var unionDePersonas = personasA.UnionBy(personasB, x => x.Nombre);

        }
    }
}
