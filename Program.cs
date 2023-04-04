using System.Transactions;

namespace Giraffe
{
    class Program
    {
        /*        static void Main(string[] args)
                {
        */
        /*           string characterName = "John";
                   int characterAge = 35;

                   Console.WriteLine("      /|");
                   Console.WriteLine("     / |");
                   Console.WriteLine("    /  |");

                   Console.WriteLine("   /   |");
                   Console.WriteLine("  /____|");


                   Console.WriteLine("There once was a man named " +  characterName + " and he was " + characterAge);


                   string phrase = "Giraffe Academy";
                   char grade = 'A';
                   int age = 30;
                   double gpa = 3.2;

                   Console.WriteLine(phrase + " has a grade of " + grade + " ," + age + ",  " + gpa);

                   Console.WriteLine(phrase.ToUpper());
                   Console.WriteLine(phrase.Contains("Academy"));
                   Console.WriteLine(phrase[2]);

                   Console.WriteLine(25 / 20);
                   Console.WriteLine(Math.Pow(10, 2));

                   Console.Write("Enter your name: ");
                   string name = Console.ReadLine();
                   Console.Write("Enter your age: ");
                   int ages = Convert.ToInt32(Console.ReadLine());
                   Console.WriteLine($"Hello {name}, you are {ages} years old.");

       */
        /*Mad Lib

        string color, pluralNoun, celebrity;

        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        Console.Write("Enter a plural noun: ");
        pluralNoun = Console.ReadLine();

        Console.Write("Enter a celebrity: ");
        celebrity = Console.ReadLine();

        Console.WriteLine($"Roses are {color}");
        Console.WriteLine($"{pluralNoun} are blue");
        Console.WriteLine($"I love {celebrity}");





        int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

        luckyNumbers[0] = 9000;

        Console.WriteLine(luckyNumbers[0]);


        Console.Write("Enter a name: ");
        string name = Console.ReadLine();
        Console.Write("Enter an age: ");
        string age = Console.ReadLine();
        string greeting = sayHi(name, age);
        Console.WriteLine(greeting);




        Console.ReadLine();


    }

    static string sayHi(string name, string age)
    {
        string message = "Hello, " + name + "! Nice to meet you." + "You are " + age + " years old";
        return message;
        */



        static void Main(string[] args)
        {


            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)

            {
                Console.WriteLine("You are male and tall");

            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are male and not tall");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not male and tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }


            Console.ReadLine();

        }
    }
}