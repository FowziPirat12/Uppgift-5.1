using System;

namespace Övning_5._1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] stad = new string [3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Skriv in en stad:");
                stad[i] = Console.ReadLine();
                Console.WriteLine($" Du skrev in:" +  stad[i]);
            }   
        }
    }
}