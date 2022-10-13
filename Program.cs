using System;

namespace tp7_ejr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int num = 0;
            int resultado =0;
            string entrada;

            Console.WriteLine("Escriba un numero al que le quiera sacar la factorial");
            entrada = Console.ReadLine();
            num = Convert.ToInt32(entrada);

            

            resultado = factorial(num);
            Console.WriteLine("el factorila del numero {0} es {1}", num, resultado);

        }
        static int factorial( int num)
        {
            int acumulador = 1;
            for (int i = 1; i <= num; i++)
            {
                acumulador = acumulador * i;
            }
            return acumulador;
        }
    }

}
