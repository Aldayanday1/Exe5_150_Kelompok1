﻿using System;

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
                Console.WriteLine("Queue Missing");
                return;
            }
        }
    }
}