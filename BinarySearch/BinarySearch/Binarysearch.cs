using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class BinarySearchTreeAdd<T> where T : IComparable
    {
        public MyBinaryNode<T> value;

        public MyBinaryNode<T> start;


        public BinarySearchTreeAdd()
        {
            value = null;
            start = null;
        }

        public void Add(T data)
        {
            if (value == null)
            {
                value = new MyBinaryNode<T>(data);
            }
            else
            {
                var node = new MyBinaryNode<T>(data);
                var temp = start;
                if (data.CompareTo(value.data) < 0)
                {
                    if (temp.leftside == null)
                        temp.leftside = node;
                    else
                    {
                        start = temp.leftside;
                        Add(data);
                    }
                }
                else
                {
                    if (temp.Rightside == null)
                        temp.Rightside = node;
                    else
                    {
                        start = temp.Rightside;
                        Add(data);
                    }
                }
            }
            start = value;
        }

        public void Display(MyBinaryNode<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.leftside != null)
            {
                Console.WriteLine("Left :" + parent.leftside.data);
            }
            if (parent.Rightside != null)
                Console.WriteLine("Right :" + parent.Rightside.data);
            if (parent.leftside != null)
            {
                Display(parent.leftside);
            }
            if (parent.Rightside != null)
            {
                Display(parent.Rightside);
            }
        }
    }
}
