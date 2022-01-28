
namespace CursoLINQ.Modulo_4_Proyecciones
{
    public class SelectManyDemo
    {
        public static void Ejemplo()
        {
            // La Funcion Select nos permite hacer una proyeccion
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
                new Persona { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
                new Persona { Nombre = "Alejandro", Telefonos = { "712-132" } },
                new Persona { Nombre = "Valentina" }
             };
            // select many apalana todo los array y los convierte a uno
            var telefonos = personas.SelectMany(x => x.Telefonos).ToList();
            // ouput: ["123-456","789-852","998-478", "568-222", "712-132"]
            // Ejemplo 2: Entendiendo SelectMany con dos colecciones diferentes
            int[] numeros = { 1, 2, 3 };
            // Convina persona con numeros
            var personasYNumeros = personas.SelectMany(p => numeros, (persona, numero) => new
            {
                Persona = persona,
                Numero = numero
            });

            foreach (var item in personasYNumeros)
            {
                //Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
            }

            // Ejemplo 3: personas y telefonos

            var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (persona, telefono) => new
            {
                Persona = persona,
                Telefono = telefono
            });
            /*
             * Ouput:
             * Eduardo - 123-456
             * Eduardo - 789-852
             * Nidia - 998-478
             * Nidia - 568-222
             * Alejandro - 712-123
             *
             */
            foreach (var item in personasYTelefonos)
            {
                Console.WriteLine($"{item.Persona.Nombre} - {item.Telefono}");
            }

            // Sintaxis de queries
            var telefonos_2 = from p in personas
                              from telefono in p.Telefonos
                              select telefono;

            var personasYNumeros_2 = from p in personas
                                     from n in numeros
                                     select new
                                     {
                                         Persona = p,
                                         Numero = n
                                     };

        }
    }
}
