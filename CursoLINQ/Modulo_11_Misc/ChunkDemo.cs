

namespace CursoLINQ.Modulo_11_Misc
{
    public class ChunkDemo
    {
        public static void Ejemplo()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // divide en 3 colecciones
            var resultado = A.Chunk(3);
            Console.WriteLine(resultado);
            // Nota: no existe sintaxis de query para este código.
        }
    }
}
