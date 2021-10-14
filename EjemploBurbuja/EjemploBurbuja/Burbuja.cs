using System;


namespace EjemploBurbuja
{
    class Burbuja
    {
        int[] lista = new int[5];
        int n, temp;

        public Burbuja()
        {
            Llenar();
            Imprimir();
            Ordenar();
        }

        private void Llenar()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("Ingrese el numero de la posicion: " + (i + 1));
                lista[i] = int.Parse(Console.ReadLine());

            }
        }

        private void Imprimir()
        {
            Console.WriteLine("Lista: ");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + "  ");
            }
            Console.ReadKey();
        }

        private void Ordenar()
        {
            do
            {
                n = 0;
                for (int i = 1; i < lista.Length; i++)
                {
                    if (lista[i - 1] > lista[i])
                    {
                        temp = lista[i - 1];
                        lista[i - 1] = lista[i];
                        lista[i] = temp;
                        n = i;
                       
                    }
                }
            } while (n!=0);




            Console.Clear();
            Imprimir();

        }
    }
}