using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int horastraba = 0;
            float sueldo = 0,total=0;
            Console.WriteLine("Digite las horas trabajadas de la semana");
            horastraba = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el sueldo que recibira");
            sueldo = float.Parse(Console.ReadLine());
            total = sueldo * horastraba;
            Console.WriteLine("El sueldo total es de: "+total);
        }
    }
}
