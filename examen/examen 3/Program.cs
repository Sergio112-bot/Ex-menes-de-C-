using System;

namespace examen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int an=11,ac=10,amesu=12,euro=24,asia = 27;
            float peso = 0,tot=0;
            Console.WriteLine("Digite el peso de su paquete");
            peso = float.Parse(Console.ReadLine());
            if (peso >= 5)
            {
                Console.WriteLine("Excede el peso limite, por lo tanto no sera transportado");
            
            }
            else
            {
                Console.WriteLine("Digite el pais al que se le va a enviar\n1.- América del norte\n2.- América central\n3.- América del sur\n4.- Europa\n5.- Asia");
                int pais = int.Parse(Console.ReadLine());
                switch (pais)
                {
                    case 1:
                        tot = peso * an;
                        Console.WriteLine("El pais de destino es Améroca de norte");
                        Console.WriteLine("El precio del pais de destino es: "+an);
                        break;
                    case 2:
                        tot = peso * ac;
                        Console.WriteLine("El pais de destino es América central");
                        Console.WriteLine("El precio del pais de destino es: "+ac);
                        break;
                    case 3:
                        tot = peso * amesu;
                        Console.WriteLine("El pais de destino es America del sur");
                        Console.WriteLine("El precio del pais de destino es: "+amesu);
                        break;
                    case 4:
                        tot = peso * euro;
                        Console.WriteLine("El pais de destino es Europa");
                        Console.WriteLine("El precio del pais de destino es: "+euro);
                        break;
                    case 5:
                        tot = peso * asia;
                        Console.WriteLine("El pais de destino es Asia");
                        Console.WriteLine("El precio del pais de destino es: "+asia);
                        break;
                }
                Console.WriteLine("El total de envio es: "+tot);


            }

        }
    }
}
