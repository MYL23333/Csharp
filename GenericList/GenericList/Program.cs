using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T  t)
            {
                Next = null;
                Data = t;
            }
        }
      
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public GenericList()
            {
                tail = head = null;
            }

            public Node<T> Head
            {
                get => head;
            }

            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
        public void ForEach(Action<T> action)
        {
            Node<T> t = this.head;
            while(t!=null)
            {
                action(t.Data);
                t = t.Next;
            }
        }
        }

        class Program
        {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
          
            intlist.ForEach((int m) => Console.Write(m));
            //
            int max = int.MinValue;
            intlist.ForEach(m => { if (max < m)  max = m; });
            Console.Write($"最大值为: { max}");
            int min = int.MaxValue;
            intlist.ForEach(m => { if (min > m) min = m; });
            Console.Write($"最小值为：{min}");
            int sum = 0;
            intlist.ForEach(m => { sum += m; });
            Console.Write($"总和为：{ sum}");
           

            }

        }
    }