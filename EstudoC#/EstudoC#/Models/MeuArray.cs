using System.Reflection.Metadata.Ecma335;

namespace EstudoC_.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private T[] array = new T[capacidade];
        private int contador = 0;

        public void AdcionarElementoArray(T Elemento)
        {
            if (contador + 1 < 11)
                array[contador] = Elemento;
            contador++;
        }

        public T this[int index]
        {
            get {return array [index]; }
            set { array [index] = value; }
        }
    }
}
