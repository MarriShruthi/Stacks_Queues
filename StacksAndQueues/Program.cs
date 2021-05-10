using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack and Queues");
            Stacks stacks = new Stacks();

            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);

            stacks.Display();

            //Peek the Top one
            stacks.Peek();
            //pop the top one
            stacks.Pop();
            stacks.IsEmpty();
            Console.ReadLine();
        }
    }
}
