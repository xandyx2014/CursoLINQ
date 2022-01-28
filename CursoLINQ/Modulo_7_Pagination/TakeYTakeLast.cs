

namespace CursoLINQ.Modulo_7_Pagination
{
    public class TakeYTakeLast
    {
        public static void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 100);
            // Tomar solamente 10
            var primeros10Numeros = numeros.Take(10).ToList();
            // tomar los ultimos 10
            var ultimos10Numeros = numeros.TakeLast(10).ToList();

            // Sintaxis de queries
            var primeros10Numeros_2 = (from n in numeros
                                       select n).Take(10);
        }
    }
}
