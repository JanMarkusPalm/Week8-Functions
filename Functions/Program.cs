using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma nimi.");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());
            SayHello(username, userAge);
        }

    private static void SayHello(string someName, int someNumber)
        {
            Console.WriteLine($"Hi There {someName}");
            Console.WriteLine($"oled sündinud aastal {2021 - someNumber}.");
        }



    }
}
