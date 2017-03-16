using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stringStack =
                new Stack<string>();
            for (int i = 1; i <= 10; i++)
                stringStack.Push(i.ToString());
            try
            {
                while (true)
                {
                    string x = stringStack.Pop();
                    Console.WriteLine(x.ToString() + " ");
                }
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message + "\n");
            }

            MyStack<string> myStringStack =
                new MyStack<string>();
            for (int i = 1; i <= 10; i++)
                myStringStack.Push(i.ToString());
            try
            {
                while (true)
                {
                    string x = myStringStack.Pop();
                    Console.Write(x.ToString() + " ");
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("\n"+e.Message);
            }

            Console.ReadKey();
        }
    }
}
