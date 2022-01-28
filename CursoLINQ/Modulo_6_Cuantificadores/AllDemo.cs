using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_6_Cuantificadores
{
    public class AllDemo
    {
        public static void Ejemplo()
        {
            var personas = new List<Persona>() {
                    new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                    new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
                    };
            // Hace una pregunta si cumple con toda la caracterisitca
            // return true
            var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);
            // todas las personas son solteros?
            var sonTodosSolteros = personas.All(p => p.Soltero);

        }
    }
}
