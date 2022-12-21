using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140012_Kelompok1
{
    class Node
    {
        public string NAME;
        public Node NEXT;
    }
    class queue
    {
        Node Muhammad, Erlangga;
        public queue()
        {
            Muhammad = null;
            Erlangga = null;
        }
        public void insert()
        {
            string ValueRead;
            Node NewNode = new Node();
            Console.WriteLine("Masukkan Element : ");
            ValueRead = Console.ReadLine();
            NewNode.NAME = ValueRead;
            NewNode.NEXT = null;
            if (Muhammad == null)
            {
                Muhammad = NewNode;
                Erlangga = NewNode;
                return;
            }
            Erlangga.NEXT = NewNode;
            Erlangga = NewNode;
        }
        public void display()
        {
            if (Muhammad == null)
            {
                Console.WriteLine(" Queue is empty!");
                return;
            }
            Node display;
            for (display = Muhammad; display != null; display = display.NEXT)
            Console.WriteLine(display.NAME);
        }
        public void delete()
        {
            if (Muhammad == null)
            {
                Console.WriteLine(" Queue is empty!");
                return;
            }
            Muhammad = Muhammad.NEXT;
            if (Muhammad == null)
                Erlangga = null;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
        }
    }
}
