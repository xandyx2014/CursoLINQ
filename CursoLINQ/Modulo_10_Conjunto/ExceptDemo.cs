﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_10_Conjunto
{
    public class ExceptDemo
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
            // Except a los B
            var NumerosEnAQueNoEstanEnB = A.Except(B);
            // return string array
            var personasBNombres = personasB.Select(x => x.Nombre);
            var personasEnAQueNoEstanEnB = personasA.ExceptBy(personasBNombres, x => x.Nombre);

        }
    }
}
