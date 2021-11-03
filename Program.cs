using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {

            double height, pesoIdeal;
            string sex;

            Console.Write("Digite sua altura em m........: ");
            
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Sexo [M]asculino / [F]eminino.: ");
            
            sex = Console.ReadLine().ToUpper().Trim().Substring(0,1);
            Console.WriteLine();

            if(sex == "M")
            {
                pesoIdeal = height * 72.7 - 58.0;

                Console.Write("Seu peso ideal é: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{pesoIdeal:N2}");
                Console.ResetColor();
                Console.WriteLine("Kg.");
            }
            else if(sex == "F")
            {
                pesoIdeal = height * 62.1 - 44.7;

                Console.Write("Seu peso ideal é: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{pesoIdeal:N2}");
                Console.ResetColor();
                Console.WriteLine("Kg.");
            }
            else
            {
                Console.WriteLine("Digite \"F\" para feminnino ou \"M\" para masculino");
            }
        }
    }
}
