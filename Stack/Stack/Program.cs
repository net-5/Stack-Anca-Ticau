using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show last element without modifying the stack.

            Stack<string> stack = new Stack<string>();
            stack.Push("Winter");
            stack.Push("Spring");
            stack.Push("Summer");
            stack.Push("Autumn");

            Console.WriteLine($"First element in stack '{stack.Peek()}'");

            var seasonNames = new List<string>();

            while (stack.Count > 0)
            {
                string seasonName = stack.Pop();

                seasonNames.Add(seasonName);

                if (stack.Count == 0)
                {
                    Console.WriteLine($"Last element in stack '{seasonName}'");
                }
            }

            seasonNames.Reverse();

            foreach (string element in seasonNames)
            {
                stack.Push(element);
            }

            Console.WriteLine($"First element in stack '{stack.Peek()}'");

            Console.ReadKey();
        }
    }
}

