using System;

namespace Tydzień2_dzień4
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Zadanie 1
            Console.WriteLine("Zadanie 1 : Tydzień2");

            string firstName = "Julia";
            string lastName = "Kowalska";
            byte age = 30;
            char sex = 'F';
            long Id = 98887722;
            long userNumber = 8872655244141663;

            Console.WriteLine($"Dane pracowanika o imieniu {firstName} to : {lastName}, {age}, {sex}, {Id}, {userNumber}");

            string Dane = Console.ReadLine();

            //Zadanie 2 

            Console.WriteLine("Zadanie 2 : Tydzień2");
            
            Console.WriteLine("1");
            string number1 = "1";        
            Console.WriteLine("2");
            string number2 = "2";
            Console.WriteLine("3");
            string number3 = "3";

            Console.WriteLine($"Odwrotna kolejność : \r\n {number3},\r\n {number2}, \r\n {number1},");

            string number321 = Console.ReadLine();

            Console.WriteLine("Wpisz pierwszą liczbę");
            string number4 = Console.ReadLine();
            Console.WriteLine("Wpisz drugą liczbę");
            string number5 = Console.ReadLine();
            Console.WriteLine("Wpisz trzecią liczbę");
            string number6 = Console.ReadLine();

            Console.WriteLine($"Odwrotna kolejność : \r\n {number6},\r\n {number5}, \r\n {number4},");

            string number654 = Console.ReadLine();

            //Zadanie 3

            Console.WriteLine("Zadanie 3 : Tydzień2");

            Console.WriteLine("Podaj długość pierwszego boku");
            double Site1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość drugiego boku");
            double Site2 = Int32.Parse(Console.ReadLine());

            Double SiteA = Math.Pow(Site1, 2);
            Double SiteB = Math.Pow(Site2, 2);

            double site3 = Math.Sqrt(SiteA + SiteB);

            Console.WriteLine($" Przekątna prostokątu ma długość {site3} \r\n \r\n "); 

            //Zadanie 4

            Console.WriteLine("Zadanie 4 : Tydzień2");

            int a;
            double b;
            string c;
                
            a = 10;
            b = 12.5;
            c = "Szkoła Dotneta"; 

            Console.WriteLine($" a. {a}, \r\n b. {b}, \r\n c. {c}, \r\n ");

            //Zadanie 5

            Console.WriteLine("Zadanie 5 : Tydzień2 \r\n");
            Console.WriteLine("Podaj swoje imię");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko");
            string lastName2 = Console.ReadLine();
            Console.WriteLine("Podaj swój numer telefonu");
            long phoneNumber3 = long.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj adres email");
            string userEmail = Console.ReadLine();
            Console.WriteLine("Podaj swój wzrost");
            long userHeight = long.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoją wagę");
            byte userWeight = byte.Parse(Console.ReadLine());

            Console.WriteLine($" Dane użytkownika: \r\n imię: {firstName1}, \r\n nazwisko: {lastName2}, \r\n numer telefonu {phoneNumber3}, \r\n adres email: {userEmail}, \r\n wzrost: {userHeight}, \r\n waga: {userWeight},  ");

        }
    }
}
