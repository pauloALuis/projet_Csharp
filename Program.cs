using System;
using System.Globalization;

namespace first_projet
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee2 employee2 = new Employee2( "Carlos Marcos",15, "");
            Console.WriteLine(employee2);
            Console.WriteLine(employee2.Password);

            employee2.Age++;

            employee2.Name="T0";
            Console.WriteLine(employee2);
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
             //Console.WriteLine($"Area: {triangulo.AreaTriangulo}");
            //Calculator.Circuference(100);

            Console.WriteLine("circunferencia " + Calculator.Circuference(100));
            student();

            Triangulo triangulo = new Triangulo() { LadoA = 18.2, LadoB = 10.8, LadoC = 48};
            Console.WriteLine(triangulo.ToString());

            Employees();
            Produts();*/


        }

        public static void Produts()
        {


            Console.WriteLine("Insera nome do Produto: (Caneca) ");
            string name = Console.ReadLine();
            Console.WriteLine("Insera o Preço do Produto: (15.2) ");

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade adicionar em Stock: (1) ");
            int num = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, num);

            Console.WriteLine(product);

            Console.WriteLine("Quantidade a remover em Stock: (1) ");
            num = int.Parse(Console.ReadLine());
            product.RemoveProduct(num);

            Console.WriteLine("Dados atualizados:\n  " + product);
        }


        public static bool CheckGreat(int numberA, int numberB)
        {
            return numberA < numberB;
        }



        public static void Employees()
        {
            Console.WriteLine("Insere nome trabalhador: (Joao) ");
            string name = Console.ReadLine();
            Console.WriteLine("Insere Salario bruto: (150.2) ");

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insere o valor do Imposto ");
            int num = int.Parse(Console.ReadLine());

            Employee product = new Employee(name, price, num);

            Console.WriteLine(product);

            Console.WriteLine("Digite a Percentagem para aumentar o salario % : (10) ");
            num = int.Parse(Console.ReadLine());
            product.IncreaseSalary(num);

            Console.WriteLine("Dados atualizados:\n  " + product);


        }


        public static void student()
        {


            Student aluno = new Student();

            Console.WriteLine("Insere nome aluno: (Joao) ");
            aluno.Name = Console.ReadLine();


            //Console.WriteLine("Insere Salario bruto: (150.2) ");

            //  double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Insere o valor do Imposto ");
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Classification[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Classification[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Classification[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.CheckApproval();
        }
    }
}
