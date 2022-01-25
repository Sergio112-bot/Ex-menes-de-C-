using System;

namespace examen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0,cant=0,salir=0;
            float tot1 = 0;
            double total = 0,tototro=0;
            do
            {
                Console.WriteLine("Bienvenido a \"El náufrago satisfecho\"");
                Console.WriteLine("Elija la hambueguesa a comprar.\n1.- Secilla \n2.- Doble\n3.- Triples");
                opc = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la cantidad de hamburguesas");
                cant = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        tot1 = cant * 20;
                        Console.WriteLine("Tipo de hamburguesa es 1 precio 20");
                        break;
                    case 2:
                        tot1 = cant * 25;
                        Console.WriteLine("Tipo de hamburguesa es 2 precio 25");
                        break;
                    case 3:
                        tot1 = cant * 28;
                        Console.WriteLine("Tipo de hamburguesa es 1 precio 28");
                        break;
                }
                Console.WriteLine("Digite su forma de pago\n1.- tarjeta\n2.- Efectivo");
                int pago = int.Parse(Console.ReadLine());
                Console.WriteLine("Total sin cargo: " + tot1);
                if (pago == 1)
                {
                    total = tot1 * 1.05;
                    Console.WriteLine("El total con cargo es : " + total);
                }
                else
                {
                    total = tot1 * 1;
                    Console.WriteLine("El total es: " + total);
                }

                tototro = tototro + total;
                Console.WriteLine("Desea otro producto\n1.-si\n2.- No");
                 salir = int.Parse(Console.ReadLine());
            } while (salir == 1);
            
        }
    }
}
