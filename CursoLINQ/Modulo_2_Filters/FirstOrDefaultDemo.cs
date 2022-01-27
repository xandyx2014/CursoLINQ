namespace CursoLINQ.Modulo_2_Filters
{
    public class FirstOrDefaultDemo
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

            var primeraPersona = personas.First();
            // este retorna el valor por defecto
            var primeraPersona2 = personas.FirstOrDefault();

            var paises = new List<string>();
            try
            {
                // este lanza un error 
                var primerPais = paises.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ha ocurrido un error {ex.Message}");
            }

            var primerPais2 = paises.FirstOrDefault();

            var numeros = new List<int>();
            var primerNumero = numeros.FirstOrDefault();
            // Aqui recibe un predicate
            var primeraPersonaNoSoltera = personas.FirstOrDefault(p => !p.Soltero);

            // Sintaxis de queries
            var primeraPersonaNoSoltera_2 = (from p in personas
                                             where !p.Soltero
                                             select p).FirstOrDefault();
        }
    }
}
