using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            string talk1,
                talk2 = "That's good to hear";

            Console.Write("What is your name?\n");
            talk1 = Console.ReadLine();

            Console.WriteLine("How are you feeling {0}?",talk1);

            Console.WriteLine("I'm okay said {0}.",talk1);

            Console.WriteLine("Well {0}, that's good to hear!", talk1,talk2);

            double num, num1, add;

            Console.WriteLine("Will you please enter your first number?");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now please enter your second number?");
           num1 = Convert.ToDouble(Console.ReadLine());

           add = num + num1;
           Console.WriteLine(add);
        }
    }
}
