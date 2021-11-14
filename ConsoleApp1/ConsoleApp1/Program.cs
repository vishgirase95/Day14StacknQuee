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


        }


        public void Display()
        {

            while (Top != null)
            {
                Console.WriteLine(Top.data);
                Top = Top.next;

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


            obj.Display();

        }
    }
}
