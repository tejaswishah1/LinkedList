using System;

namespace LinkedListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");

            LinkedList linklist = new LinkedList();
            linklist.Add(56);
            linklist.Add(30);
            linklist.Add(70);

            linklist.Display();

        }
    }
}
