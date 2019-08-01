using System;

namespace asg3
{
    class Program
    {
        static void Main(string[] args)
        { 
            News n = new News();
            while (true)
            {
                int choice;
                Console.WriteLine("Menu");
                Console.WriteLine("1| Insert news");
                Console.WriteLine("2| View list news.");
                Console.WriteLine("3| Average rate.");
                Console.WriteLine("4| Exit.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        n.AddNews();
                        break;
                    case 2:
                        n.Display();
                        break;
                    case 3:
                        n.Average = 1;
                        n.Display();
                        n.Average = 0;
                        break;
                    case 4:
                        Console.WriteLine("Bye.");
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }   
            }
        }
    }
}