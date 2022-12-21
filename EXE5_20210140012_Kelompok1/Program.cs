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
            queue q = new queue();
            char cr;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Delete");
                    Console.WriteLine("3. Dispay");
                    Console.WriteLine("4. Exit");
                    Console.Write("\n Enter Your Choise (1-4)");
                    cr = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (cr)
                    {
                        case '1':
                            {
                                q.insert();
                                break;
                            }
                        case '2':
                            { 
                                q.delete();
                                break;
                            }
                        case '3':
                            {
                                q.display();
                                break;
                            }
                        case '4':
                            {
                                return;
                            }
                            default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
            }
        }
    }
}
