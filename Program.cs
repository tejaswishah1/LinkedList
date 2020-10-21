using System;

namespace LinkedListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");

            LinkedList linklist = new LinkedList();
            //linklist.Add(56);
            //linklist.Add(30);
            //linklist.Add(70);


            ////UC2-Add-at-first:
            //linklist.AddAtFirst(70);
            //linklist.AddAtFirst(30);
            //linklist.AddAtFirst(56);

            ///UC3-Append
            linklist.Append(56);
            linklist.Append(30);
            linklist.Append(70);

            linklist.Display();

        }
    }
}
