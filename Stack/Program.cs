﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            for (int i = 1; i <= 10; i++)
                stringStack.Push(i.ToString());
            List<string> stringList = stringStack.ToList();
            stringList.Reverse();
            foreach(var x in stringList)
                Console.Write(x + " ");
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
                myStringStack.Push(i.ToString());
            List<string> myStringList = myStringStack.ToList();
            foreach(var x in myStringList)
                Console.Write(x + " ");
            Console.WriteLine();

            foreach (var x in myStringStack)
                Console.Write(x.ToString() + " ");
            Console.WriteLine();

            MyStack<string> secondStack = (MyStack<string>) myStringStack.Clone();
            foreach(var x in secondStack)
                Console.Write(x.ToString() + " ");
            Console.WriteLine();

            Stack<string> thirdStack = myStringStack.ToStack();
            foreach (var x in thirdStack)
                Console.Write(x.ToString() + " ");
            Console.WriteLine();


            MyStack<int> intStack = new MyStack<int>();
            for (int i = 1; i <= 10; i++)
                intStack.Push(i);
            try
            {
                for (int i = 0; i < 12; i++)
                    Console.WriteLine(intStack[i]);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
               // return;
            }
            Console.ReadKey();
        }
    }
}
