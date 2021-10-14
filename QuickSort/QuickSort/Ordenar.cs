using System;


namespace QuickSort
{
    class Ordenar
    {
        int[] arreglo;

        public Ordenar()
        {
            Llenar();
        }

        private void Llenar()
        {
            int x;
            Console.WriteLine("Introduzca la dimension del arreglo:");
            x = int.Parse(Console.ReadLine());
            arreglo = new int[x];
            Console.Clear();
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Introduce el "+(i + 1) + " numero:");
                arreglo[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Imprimir();
            Rapido(arreglo,0,arreglo.Length-1);
            Imprimir();
        }

        private void Rapido(int[]arreglo,int p,int u)
        {
            int i, j, central;
            double pivote;
            central = (p + u) / 2;
            pivote = arreglo[central];
            i = p;
            j = u;
            do
            {
                while (arreglo[i] < pivote) i++;
                {
                    while (arreglo[j] > pivote) j--;
                    {
                        if (i <= j)
                        {
                            Cambio(i,j);
                            i++;
                            j--;
                        }
                    }
                }

            } while (i<=j);
            if (p < j)
            {
                Rapido(arreglo,p,j);
            }
            if (i < u)
            {
                Rapido(arreglo, i, u);
            }

        }


        private void Cambio(int i1,int i2)
        {
            int aux;
            aux = arreglo[i1];
            arreglo[i1] = arreglo[i2];
            arreglo[i2] = aux;
        }




        private void Imprimir()
        {
            Console.WriteLine("Impresion del arreglo: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" " +arreglo[i]);
                
            }
            Console.WriteLine();
        }



    }
}
