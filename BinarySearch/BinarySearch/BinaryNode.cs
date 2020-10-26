using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class MyBinaryNode<T> where T : IComparable
    {
        public T data;
        public MyBinaryNode<T> leftside;
        public MyBinaryNode<T> Rightside;

        public MyBinaryNode(T data)
        {
            this.data = data;
            leftside = null;
            Rightside = null;
        }
    }
}
