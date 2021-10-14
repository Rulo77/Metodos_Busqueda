using System;


namespace Shakersort
{
    class Shaker
    {
        int[] arreglo;
        int x, izquierda, derecha, ultimo, aux;

        public Shaker()
        {
            Console.WriteLine("Dame la dimension ya!!!");
            x = int.Parse(Console.ReadLine());
            arreglo = new int[x];
            Llenar();
        }

        private void Llenar()
        {
            Console.WriteLine("Llenando arreglo.....");
            for(int i = 0; i < x; i++)
            {
                Console.Write("Introduzca la posicion " + (i + 1) + ":");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            Imprimir();
            Ordenamiento();
        }

        private void Ordenamiento()
        {
            izquierda = 0;
            derecha = arreglo.Length - 1;
            ultimo = arreglo.Length - 1;
            do
            {

                for (int i = arreglo.Length - 1; i > 0; i--)
                {
                    if (arreglo[i - 1] > arreglo[i])
                    {
                        aux = arreglo[i];
                        arreglo[i] = arreglo[i - 1];
                        arreglo[i - 1] = aux;
                        ultimo = i;
                    }
                }
                izquierda = ultimo + 1;
                for (int i = 1; i < arreglo.Length; i++)
                {
                    if (arreglo[i - 1] > arreglo[i])
                    {
                        aux = arreglo[i];
                        arreglo[i] = arreglo[i - 1];
                        arreglo[i - 1] = aux;
                        ultimo = i;
                    }
                }
                derecha = ultimo - 1;
                Imprimir();
                Console.WriteLine(" ");
            } while (derecha>=izquierda);

           // Imprimir();
        }

        private void Imprimir()
        {
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + "  ");
            }
            Console.WriteLine();
        }

        
    }
}
