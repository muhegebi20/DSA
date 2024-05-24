using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace Stack
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

    }

    class stackContainer
    {
        private Node head = null;

        public void Push(int data)
        {
            if( head == null)
            {
                head = new Node(data);
                return;
            }

            Node temp = new Node(data);
            temp.Next = head;
            head = temp;

        }

        public void Display()
        {
            Node iter = head;
            Console.WriteLine();
            while (iter != null)
            {
                Console.WriteLine(iter.Data);
                iter = iter.Next;
            }
        }

        public void Pop()
        {
            //
            int temp = head.Data;
            head = head.Next;
        }
        public void Peak()
        {
            //
            int data = head.Data;
            Console.WriteLine("Top Data is {0}", data);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            stackContainer stack = new stackContainer();
            
            Console.WriteLine("Stack Data Structure");
            Console.WriteLine("Choose the application You wanna do!");

            Console.WriteLine("1 Push");
            Console.WriteLine("2 Pop");
            Console.WriteLine("3 Peak");
            Console.WriteLine("4 Display");

            while (true)
            {
                Console.WriteLine(); // new line
                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Data: ");
                switch (choice)
                {
                    case 1: 
                        int data = int.Parse(Console.ReadLine());
                        stack.Push(data); 
                        break;
                    case 2:
                    stack.Pop() ; 
                        break;
                    case 3:
                    stack.Peak();
                        break;
                    case 4: 
                        stack.Display();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
