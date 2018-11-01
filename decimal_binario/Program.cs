using System;

namespace decimal_binario
{
    class Program
    {
        static void Main(string[] args)
        {
           const int BASE =2;
            int valor =0;
            int cont = 0;
            int guardar = 0;
            int I = 0;
            int [] vt = new int[15];
            string linea;
            Console.Write("Ingrese un Numero:");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            guardar = 1;
            while ((valor >= BASE))
            {
                cont = valor % BASE;
                vt[guardar] = cont;
                guardar = guardar + 1;
                valor = valor / BASE;
            }
            vt[guardar] = valor;
            
            for (I = guardar; I >= 1;I += -1)
            {
                Console.Write(vt[I] + " ");
            }
            Console.WriteLine();
            Console.Write("Presiona cualquier tecla:");
            Console.ReadLine();
        }
    }    
} 
