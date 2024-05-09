using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            int[] values = { 1, 10, -30, 10, -5 };
            foreach (int value in values)
            {
                list.Add(value); 
                stack.Push(value); 
                queue.Enqueue(value); 
                hashSet.Add(value); 
            }
            Console.WriteLine("List: ");
            foreach (int value in list)
            {
                Console.WriteLine(value + ", ");
            }

            Console.WriteLine("Stack: ");

            while (stack.Count > 0)
            {
                int value = stack.Pop();
                Console.WriteLine(value + ", ");
            }
            
            Console.WriteLine("Queue: ");
        
            while (queue.Count > 0)
            {
                int value = queue.Dequeue();
                Console.WriteLine(value + ", ");
            }

            Console.WriteLine("HashSet: ");
            foreach (int value in hashSet)
            {
                Console.WriteLine(value + ", ");
            }
        }
    }
}
