using System;

namespace examen_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            float estatu = 0,sum=0,prom=0;
            Console.WriteLine("Digite la cantidad de personas para determinar su estatura promedio");
            cant = int.Parse(Console.ReadLine());
            for (int i=1;i<=cant;i++)
            {
                Console.WriteLine("Digite la estatura");
                estatu = float.Parse(Console.ReadLine());
                sum = sum + estatu;
            }
            prom = sum / cant;
            Console.WriteLine("El promedio de las estaturas es de: " + prom);
        }
    }
}
