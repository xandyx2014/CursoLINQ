using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_7_Pagination
{
    public class Paginacion
    {
        public static void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 100);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Página {i}");
                var paginado = numeros.Paginar(i, 10);
                foreach (var item in paginado)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Paginar<T>(this IEnumerable<T> coleccion, int pagina, int size)
        {
            return coleccion.Skip((pagina - 1) * size).Take(size);
        }
    }
}
