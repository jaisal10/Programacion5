

using System;
using System.Collection.Generic; 
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Programa
    {
        static void Main(string[] args)
        {
            int b,a, area, num;
            string si;
            console.WriteLine("Eliga una figura geometrica");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Rectangulo");
            Console.WriteLine("3. Trianglo");
            Console.WriteLine("4. Salir");
            num = Convert.ToInt32(Console.ReadLine());
            Console.writeLine("Ponga la base o el lado");
            b= Convert.ToInt32(Console.Readline());
            Console.Writeline("Ponga la altura o el lado");
            a= Convert.ToInt32(console.ReadLine());
            switch (num)
            {
                case 1:
                    area = b*a;
                    Console.WriteLine("El area del cuadrado es: "+area);
                    break;
                case 2:
                    area = b*a;
                    Console.WriteLine("El area del rectangulo es: "+area);
                    break;
                case 3:
                    area = b*a/2;
                    Console.WriteLine("El area del triangulo es: "+area);
                    break;
            }
            Consolr.WriteLine("Desea volver a iniciar?");
            si = Console.ReadLine(); 
        }
        
    }
    
}