using System;

namespace ConsoleApp19

{
    public class Node
    {

        public Node next;
        public int data;
     
        public Node(int x)
        {
            data = x;
            next = null;
            


        }

    }


    class Program
    {
        public Node Top = null;
        public Node next = null;


        public void push(int x)
        {
            Node node = new Node(x);

            node.next = Top;
            Top = node;
            Console.WriteLine("Added :" + x);

        }
        public void pop()
        {
            Console.WriteLine("The is poped :" + Top.data);

            Top = Top.next;
        }
        public void peak()
        {
            Node temp = Top;
           if(temp == null)
            {

                Console.WriteLine("Top is null");
            }
            else
            {
                Console.WriteLine("The peak is :" + temp.data);
            }

        }

        public void IsEmpty()
        {
            while (Top != null)
            {
                pop();
            }
        }

        public void Enquee(int x)
        {
            Node node = new Node(x);

            node.next = Top;
            Top = node;
            Console.WriteLine("Added :" + x);

        }
        public void Deque()
        {
            Top = Top.next;


        }
        public void Display()
        {
            Node Temp = Top;
            if (Temp == null)
            {
                Console.WriteLine("It is empty");
            }
            while (Temp != null)
            {
                Console.WriteLine(Temp.data);
                Temp = Temp.next;

            }
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program obj = new Program();
            obj.push(10);
            obj.push(20);
            obj.push(30);
            obj.push(40);

            Console.WriteLine("--------After Adding data----------");


            obj.Display();

         

            obj.peak();
            Console.WriteLine("--------After peaking the data----------");
            obj.Display();

            obj.pop();
            Console.WriteLine("--------After pooping the data----------");
            obj.Display();


            Console.WriteLine("--------Applying IsEmpty----------");

            obj.IsEmpty();
            Console.WriteLine("--------After IsEmpty the data----------");
            obj.Display();


            Console.WriteLine("--------Quee After enquee----------");
            obj.Enquee(1);
            obj.Enquee(2);
            obj.Enquee(3);
            obj.Display();

            obj.Deque();
            Console.WriteLine("--------Quee After Denquee----------");
            obj.Display();


        }
    }
}
