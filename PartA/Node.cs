/*
 * Andrew Dorre
 * Module 06 Project
 * Part A
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    //Taken from the book, this is a pretty simple implementation of a node
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
}
