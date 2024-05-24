namespace linked_list
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

    class LinkedList
    {
        private Node head = null;
        
        public void addToList(int data)
        {
            if( head == null)
            {
                head = new Node(data);
                return;
            }

            Node iter = head;
            while (iter.Next != null)
            {
                iter = iter.Next;
            }
            iter.Next = new Node(data);
        }

        public void Display()
        {
            Node iter = head;
            while ( iter != null)
            {
                Console.Write(iter.Data + "->");
                iter = iter.Next;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Linked List!");

            LinkedList list = new LinkedList();
            //list.addToList(10);

            for (int i = 1; i <= 10; i++)
            {
                list.addToList(i*4);
            }    

            list.Display();
            Console.ReadLine();
        }
    }
}
