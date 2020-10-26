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
        public int Size()
        {
            var temp = value;
            var maxSize = 0;
            var stk = new Stack<MyBinaryNode<T>>();


            while (temp != null || stk.Count != 0)
            {
                var size = 0;
                while (temp != null)
                {
                    stk.Push(temp);
                    temp = temp.leftside;
                    size++;
                }
                temp = stk.Pop();

                temp = temp.Rightside;
                maxSize = maxSize < size ? size : maxSize;

            }
            return maxSize - 1;
        }
        public void Search(T data)
        {
            if (start.data.CompareTo(data) == 0)
            {
                Console.WriteLine("Found");
                return;
            }
            if (start.data.CompareTo(data) < 0)
            {
                start = start.Rightside;
                Search(data);

            }
            else
            {
                start = start.leftside;
                Search(data);
            }
        }
        public void Display(MyBinaryNode<T> start)
        {
            Console.WriteLine("Start : {0}", start.data);
            if (start.leftside != null)
            {
                Console.WriteLine("Left :" + start.leftside.data);
            }
            if (start.Rightside != null)
                Console.WriteLine("Right :" + start.Rightside.data);
            if (start.leftside != null)
            {
                Display(start.leftside);
            }
            if (start.Rightside != null)
            {
                Display(start.Rightside);
            }
        }
    }
}
