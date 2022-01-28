

namespace CursoLINQ.Modulo_11_Misc
{
    public class TryGetNonEnumeratedCountDemo
    {
        public static void Ejemplo()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var conteo = 0;
            Console.WriteLine(conteo);
            var pudoContarASinEnumerar = A.TryGetNonEnumeratedCount(out conteo);
            Console.WriteLine(conteo);
            Console.WriteLine(pudoContarASinEnumerar);
            var personasA = new List<Persona>()
            {
                new Persona{Nombre = "Eduardo", EmpresaId = 1},
                new Persona{Nombre = "Nidia", EmpresaId = 1},
                new Persona{Nombre = "Esmerlin", EmpresaId = 3}
            };

            var personasCollection = new PersonasCollection();
            personasCollection.AddRange(personasA);

            var conteoPersonas2 = 0;
            Console.WriteLine(conteoPersonas2);
            bool pudoContarPersonasSinEnumerar = personasCollection.TryGetNonEnumeratedCount(out conteoPersonas2);
            Console.WriteLine(pudoContarPersonasSinEnumerar);
            Console.WriteLine(pudoContarASinEnumerar);
        }

        public class PersonasCollection : IEnumerable<Persona>, ICollection<Persona>
        {
            private readonly List<Persona> _personas = new();

            public int Count => _personas.Count;

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(Persona persona)
            {
                _personas.Add(persona);
            }

            public void AddRange(IEnumerable<Persona> personas)
            {
                _personas.AddRange(personas);
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(Persona item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Persona[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<Persona> GetEnumerator()
            {
                return _personas.GetEnumerator();
            }

            public bool Remove(Persona item)
            {
                throw new NotImplementedException();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<Persona>)_personas).GetEnumerator();
            }
        }


    }

}
