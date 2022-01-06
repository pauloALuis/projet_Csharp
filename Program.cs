using System;
using System.Globalization;

namespace first_projet
{
    class Program
    {
        static void Main(string[] args)
        {
            /* double typeDouble = 10.0710;

             sbyte typeSByte = 100;
             char letter = '\u2766';
             Console.WriteLine("Hello World! " + typeSByte.ToString() );
             Console.WriteLine("teste");
             Console.WriteLine(letter);
             Console.WriteLine(typeDouble.ToString("F1"));
             Console.WriteLine(typeDouble.ToString("F2", CultureInfo.InvariantCulture));


             Console.WriteLine("{0} tere {1} erere {2:F3}",letter, typeDouble, typeSByte);



             //&& ---- || ---- | 
             int number = 15;

             Console.WriteLine("Digite um numero interiro");

             int num = int.Parse(Console.ReadLine());


             if (num < 10)
             {
                 Console.WriteLine("Menor");
             }
             else if( checkGreat(num, number))
             {
                 Console.WriteLine("Maior");

             }
             else
             {
                 Console.WriteLine("Nope");

             }


             Triangulo triangulo = new Triangulo(185.5 ,2589.2, (int)2599.6);

             Console.WriteLine($"Area: {triangulo.AreaTriangulo}");
             triangulo.PrintArea();
             //Console.WriteLine($"Area: {triangulo.AreaTriangulo}");*/


            Console.WriteLine("Insera nome do Produto: (Caneca) ");
            string name = Console.ReadLine();
            Console.WriteLine("Insera o Preço do Produto: (15.2) ");

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidaed em Stock: (1) ");
            int num = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, num);

            Console.WriteLine(product);

        }


        public static bool checkGreat(int numberA, int numberB)
        {
            return numberA < numberB;
        }
    }
}
