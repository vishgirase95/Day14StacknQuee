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

        public void Display()
        {
            Node Temp = Top;

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

        }
    }
}
