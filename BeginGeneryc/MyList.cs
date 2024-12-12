using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BeginGeneryc
{
    public class MyList<T> : IEnumerable<T>
    {
        private Node<T> head; //Голова
        private Node<T> tail; //Хвіст - останій елемент списку Next == null
        private int _count;

        public int Count
        {
            get { return _count; }
            private set { _count = value; }
        }

        public MyList()
        {
            head = null;
            tail = null;
            Count = 0; 
        }

        public void Add(T item)
        {
            Node<T> temp = new Node<T>(item);
            if (head == null)
            {
                head = temp;
                tail = temp;
            }
            else
            {
                tail.Next = temp; //Зберігаємо наступний елемнет у Next
                tail = temp;      //Наступний елемент стає у хвіст
            }
            Count++;
        }

        public bool Remove(T value)
        {
            if (head == null) return false;
            if (head.Value.Equals(value))
            {
                head = head.Next;
                return true;
            }
            var current = head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public T this[int index]
        {
            get
            {
                var current = head;
                int k = 0;
                while (k != index)
                {
                    current = current.Next;
                    k++;
                }
                return current.Value;
            }
            set
            {
                var current = head;
                int k = 0;
                while (k != index)
                {
                    current = current.Next;
                    k++;
                }
                current.Value = value;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            var current = head;
            var result = "";
            while (current != null)
            {
                result += current.Value.ToString() + "\t";
                current = current.Next;   //Переходимо на наступний елемент
            }
            return result;
        }
    }
}
