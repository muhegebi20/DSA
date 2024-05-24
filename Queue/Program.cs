namespace Queue
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

    class Queue
    {
        Node head = null;
        Node tail = null;

        public void addToQue(int data)
        {
            if( head == null)
            {
                head = tail = new Node(data);
                return;
            }

            Node temp = new Node(data);
            tail.Next = temp;
            tail = temp;

        }

        public void dequeue()
        {
            int data = head.Data;
            head = head.Next;
            Console.WriteLine("{0} is deleted",data);
        }
        public void Display()
        {
            Node iter = head;
            while (iter != null)
            {
                Console.Write(iter.Data+" ");
                iter = iter.Next;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.addToQue(11);
            q.addToQue(5);
            q.addToQue(6);
            q.addToQue(7);
            q.addToQue(8);

            q.Display();
            Console.WriteLine();
            q.dequeue();
            q.Display();
            
        }
    }
}
