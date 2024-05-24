namespace paranthesisCHecker
{
    class Node
    {
        public char Par;
        public Node Next;

        public Node(char par)
        {
            this.Par = par;
            this.Next = null;
        }
    }

    class ParanthesChecker
    {
        private Node head = null;
        public int top = -1;

        public void Push(char par)
        {
            top++;
            if( head == null)
            {
                head = new Node(par);
                
                return;
            }
            Node temp = new Node(par);
            temp.Next = head;
            head = temp;
        }
        public void Pop()
        {
            if( head != null)
            {
                Node temp = head;
                top--;
                head = head.Next;
            }
            
        }
        public char Peak()
        {
            if(head != null)
            {
                return head.Par;
            }
            return '\n';      
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ParanthesChecker check = new ParanthesChecker();

            char[] correctArray = new char[] { '(', '{', '[', '(', ')', ']', 'a', '}', '{', '}', ')', '(', ')' };
            char[] WrongArray = new char[] { '(', '{', '[', ')', '}', '(', ']', '{', '}', ')' };

            bool result = Correct_Use(correctArray);
            if (result)
            {
                Console.WriteLine("Paranthesis are used in correct order!");
            }
            else 
            { Console.WriteLine("Paranthesis are not in correct order!"); 
            }
        }

        public static bool Correct_Use(char[] arr)
        {
            ParanthesChecker check = new ParanthesChecker();
            char ch;
            foreach (var paranths in arr)
            {
                switch (paranths)
                {
                    case '(':
                        check.Push(paranths); break;
                    case ')':
                        ch = check.Peak();
                        if (ch == '(')
                        {
                            check.Pop();
                        }
                        break;
                    case '{':
                        check.Push(paranths); break;
                    case '}':
                        ch = check.Peak();
                        if (ch == '{')
                        {
                            check.Pop();
                        }
                        break;
                    case '[':
                        check.Push(paranths); break;
                    case ']':
                        ch = check.Peak();
                        if (ch == '[')
                        {
                            check.Pop();
                        }
                        break;
                    default:
                        continue;
                }
            }

            if( check.top == -1)
            {
                return true;
            }
            return false;
        }
    }
}
