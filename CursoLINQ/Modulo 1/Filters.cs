

namespace CursoLINQ.Modulo_1
{
    class Filters
    {
        public Filters()
        {
            int[] numeros = Enumerable.Range(1, 20).ToArray();
            // Sintaxis de metodos
            var impares = numeros.Where(x => x % 2 == 0).ToList();
            var imparesQuery = from n in numeros
                               where n % 2 == 0
                               select n;
            imparesQuery.ToList().ForEach(x => Console.WriteLine(x));
            // impares.ForEach(x => Console.WriteLine(x));
        }
    }
}
