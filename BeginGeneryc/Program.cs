using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginGeneryc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Привіт!");
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list);

            list.Remove(2);
            Console.WriteLine("-----Remove-----");
            //Console.WriteLine(list);
            foreach (int i in list)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            
        }
    }
}
