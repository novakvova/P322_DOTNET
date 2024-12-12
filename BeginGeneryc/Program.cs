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
            //Console.WriteLine("Привіт!");
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(-1);
            Console.WriteLine(list);

            //list.Sort();
            //Console.WriteLine(list[1]);

            list.Remove(2);
            Console.WriteLine("-----Remove-----");
            //Console.WriteLine(list);
            foreach (int i in list)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            MyList<Contact> contacts = new MyList<Contact>();
            contacts.Add(new Contact { Name = "Марко Іван", Phone = "+38(096) 23 12 345" });
            contacts.Add(new Contact { Name = "Мельник Вікторія", Phone = "+38(096) 98 12 315" });
            contacts.Add(new Contact { Name = "Альчук Максим", Phone = "+38(096) 89 12 315" });

            //contacts.Sort();
            
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }

            contacts.Remove(new Contact { Phone = "+38(096) 98 12 315" });

            Console.WriteLine("Remove +38(096) 98 12 315");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }

        }
    }
}
