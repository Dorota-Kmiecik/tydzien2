using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzien2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1:
            string firstName;
            string lastName;
            char sex;
            string pesel;
            string employerNumber;

            //Zadanie 2
            char x = 'A';
            char y = 'B';
            char z = 'C';
            Console.WriteLine($"{z}, {y}, {x}");

            //Zadanie 3
            int lenght = 4;
            int width = 7; 
            int lenghtPow = (int)Math.Pow( lenght, 2 );
            int widthPow = (int)Math.Pow( width, 2 );
            double diagonal = Math.Sqrt( lenghtPow + widthPow);
            Console.WriteLine(diagonal);

            // Zadanie 4
            int number1 = 10;
            double number2 = 12.5;
            string name = "Szkola Dotneta";

            // Zadanie 5
            Console.WriteLine("Podaj swoje imie");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Podaj swoja wage");
            double weight;
            if (!double.TryParse(Console.ReadLine(), out weight))
                int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj numer telefonu");
            string phoneNumber = Console.ReadLine();
        }
    }
}
