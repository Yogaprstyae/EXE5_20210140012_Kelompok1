using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140012_Kelompok1
{
    class Node
    {
        public string nama;
        public Node next;
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
            string valueread;
            Node NewNode = new Node();
            Console.WriteLine("Masukkan Input ");
            valueread = Console.ReadLine();
            NewNode.nama = valueread;
            NewNode.next = null;
            if (Muhammad == null)
            {
                Muhammad = NewNode;
                Erlangga = NewNode;
                return;
            }
            Erlangga.next = NewNode;
            Erlangga = NewNode;
        }
        public void delete()
        {
            if (Muhammad == null)
            {
                Console.WriteLine("Tidak ada data dalam antrian!");
                return;
            }
            Console.WriteLine("Data yang dihapus dari antrian : " + Muhammad.nama);
            Console.ReadKey();
            Muhammad = Muhammad.next;
            if (Muhammad == null)
                Erlangga = null;
        }
        public void display()
        {
            if (Muhammad == null)
            {
                Console.WriteLine(" Queue is empty!");
                return;
            }
            Node display;
            for (display = Muhammad; display != null; display = display.next)
                Console.WriteLine(display.nama);
            Console.WriteLine("\nTekan 'Enter' untuk melanjutkan program");
            Console.ReadKey();
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            queue qw = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Insert Data");
                    Console.WriteLine("2. Delete Data");
                    Console.WriteLine("3. Dispay Data");
                    Console.WriteLine("4. Exit");
                    Console.Write("\n Enter Your Choise :");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                                Console.Clear();
                                qw.insert();
                                break;
                        case '2':
                                Console.Clear();
                                qw.delete();
                                break;
                        case '3':
                                Console.Clear();
                                qw.display();
                                break;
                        case '4':
                                return;
                            default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Silahkan periksa kembali data yang anda masukkan!");
                }
            }
        }
    }
}
