using System;
using System.Collections.Generic;

namespace Laborator11curs
{
    /* Scrieti un program care va creea un arbore si il va parcurge*/
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node(530);

            var n2 = new Node(2);
            var n33 = new Node(33);
            var n24 = new Node(24);

            var n143 = new Node(143);
            var n55 = new Node(55);
            var n23 = new Node(23);
            var n44 = new Node(44);

            var n20 = new Node(20);
            var n66 = new Node(66);
            var n154 = new Node(154);

            root.nodes.Add(n2);
            root.nodes.Add(n33);
            root.nodes.Add(n24);

            n2.nodes.Add(n143);
            n2.nodes.Add(n55);

            n24.nodes.Add(n23);
            n24.nodes.Add(n44);

            n23.nodes.Add(n20);

            n44.nodes.Add(n66);
            n23.nodes.Add(n154);

            Console.WriteLine(root.Data);
            Parcurge(root);

        }

        public static void Parcurge(Node nod)
        {
           
            foreach (var n in nod.nodes)
            {
                Console.WriteLine(n.Data);
                Parcurge(n);
            }
        }
    }

    

    class Node

    {
         public Node(int data)
        {
            this.Data = data;

        }
        public int Data { get; set; }
        public List<Node> nodes = new List<Node>();

    }
}
