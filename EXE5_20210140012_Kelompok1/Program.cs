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
            string NM;
            Node NewNode = new Node();
            Console.WriteLine("Masukkan Element : ");
            NM = Console.ReadLine();
            NewNode.NAME = NM;
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
    }
}
