using System;


namespace BusquedaMergesort
{
    class PruebaM
    {
        int[] array;
        int x;

        public PruebaM()
        {
            Llenar();
        }

        private void Llenar()
        {
            Console.WriteLine("introduzca la dimensión del arreglo:");
            x = int.Parse(Console.ReadLine());
            array = new int[x];

            for(int i=0; i < x; i++)
            {
                Console.Write("Introduzca el valor de la " + (i + 1) + " posición: ");
                array[i] = int.Parse(Console.ReadLine());

            }

            Imprimir();
            MargeSort(array,0,array.Length-1);
        }

        private void MargeSort(int[] array,int inicio,int final)
        {
            if (inicio == final)
            {
                return;
            }
            int mitad = (inicio + final) / 2;

            MargeSort(array,inicio,mitad);

            MargeSort(array, mitad + 1,final);

            int[] aux = JuntarArray(array, inicio, mitad, mitad + 1, final);

            Array.Copy(aux,0,array,inicio,aux.Length);
            Console.WriteLine();
            Imprimir();
        }


        private int[] JuntarArray(int[] array, int inicio, int fin, int inicio2, int fin2)
        {
            int aux1 = inicio;
            int aux2 = inicio2;
            int[] resultado = new int[fin - inicio + fin2 - inicio2 + 2];

            for (int i = 0; i < resultado.Length; i++)
            {
                if (aux2 != array.Length)
                {
                    if (aux1 > fin && aux2 <= fin2)
                    {
                        resultado[i] = array[aux2];
                        aux2++;
                    }
                    if (aux2 > fin2 && aux1 <= fin)
                    {
                        resultado[i] = array[aux1];
                        aux1++;
                    }
                    if (aux1 <= fin && aux2 <= fin2)
                    {
                        if (array[aux2] <= array[aux1])
                        {
                            resultado[i] = array[aux2];
                            aux2++;
                        }
                        else
                        {
                            resultado[i] = array[aux1];
                            aux1++;
                        }
                    }
                    
                }
                else
                {
                    if (aux1 <= fin)
                    {
                        resultado[i] = array[aux1];
                        aux1++;
                    }
                }
            }

            return resultado;

        }

        public void Imprimir()
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
