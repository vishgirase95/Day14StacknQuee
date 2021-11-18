using System;
using  System.Collections.Generic; 

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

            Console.WriteLine("added"+node.data);
            node.next = Top;
            Top = node;


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

            if (Top == null)
            {
                Top = node;
            }
            else
            {
                Node temp = Top;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
              
                temp.next = node;
            }
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
            obj.push(1);
            obj.push(2);
            obj.push(3);
            obj.push(4);

            Console.WriteLine("--------After PUSH data by stack----------");


            obj.Display();

         

            obj.peak();
            Console.WriteLine("--------After peaking the data by stack----------");
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


            Console.WriteLine("------AFTER PUSH STACK FROM COLLECTION---------");

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            foreach (var item in myStack)
                Console.Write(item + ",");


            Console.WriteLine("------AFTER ENQUEE FROM COLLECTION---------");

            Queue<int> myQuee=new Queue<int>();
            myQuee.Enqueue(1);
            myQuee.Enqueue(2);
            myQuee.Enqueue(3);
            myQuee.Enqueue(4);
            foreach (var item in myQuee)
                Console.Write(item + ",");

        }
    }
}
