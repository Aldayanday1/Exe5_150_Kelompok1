using System;

namespace Exe5_150_Kelompok1
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node front, rear;
        public queue()
        {
            front = null;
            rear = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (front == null)
            {
                front = newnode;
                rear = newnode;
                return;
            }
            rear.next = newnode;
            rear = newnode;
        }
        public void delete()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Kosong");
                return;
            }
            front = front.next;
            if (front == null)
                rear = null;
        }
        public void display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Kosong");
                return;
            }
            Node Current;
            for (Current = front; Current != null; Current = Current.next)
            Console.WriteLine(Current.name);

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("======Menu======");
                    Console.WriteLine("1. Enter");
                    Console.WriteLine("2. Delete");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nSilahkan Pilih 1 - 4");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.insert();
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                                return;
                                default:
                            {
                                Console.WriteLine("Opsi Tidak Tersedia");
                            }
                            break;
                            
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Silahkan cek");
                }
            }
        }
    }
}