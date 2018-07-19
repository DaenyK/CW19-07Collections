using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> link = new LinkedList<string>();
            link.AddFirst("Alex");
            link.AddFirst("Gjek");
            link.AddFirst("Bob");
            link.AddFirst("Shon");

            //отобразим элементы в прямом направлении
            LinkedListNode<string> node;
            for (node = link.First; node != null; node = node.Next)
            {
                if (node.Value == link.Last.Value)
                {
                    Console.WriteLine(node.Previous.Value + "-" + node.Value);
                }
                else if (node.Value == link.First.Value)
                {
                    Console.WriteLine(node.Value + "-" + node.Next.Value);
                }
                else
                {
                    Console.WriteLine(node.Previous.Value + "-" + node.Value + "-" + node.Next.Value);
                }

            }

            return;


            //--------------------------------------------------------------------------------
            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1, 5);
            d.Add(2, 5);
            d.Add(3, 5);

            foreach (var item in d)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
                
            }
            if (d.ContainsKey(2))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("нашел ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }


            //   Lookup<int, int> l = new Lookup<int, int>();
            //--------------------------------------------------------------------------------


            Queue<int> qe = new Queue<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                qe.Enqueue(rnd.Next(1, 20));
            }
            Console.WriteLine("очередь: ");
            foreach (int item in qe)
                Console.WriteLine(item);



            Console.WriteLine("очередь 2(c вытаскиванием): ");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(qe.Dequeue());

            Console.WriteLine("count: " + qe.Count);



            //--------------------------------------------------------------------------------
            ArrayList obj = new ArrayList() { 1, 2, "str", 'c', 0.2f, true };
            WriteCollection(obj);

            ArrayList collection = Exmp01(15);
            Console.WriteLine("\nисходная коллекция чисел: ");
            WriteCollection(collection);

            Console.WriteLine("\nпосле удаления с 1 по 5: ");
            RemoveElement(1, 5, ref collection);
            WriteCollection(collection);

            Console.WriteLine("\nпосле сортировки: ");
            collection.Sort();
            WriteCollection(collection);


        }

        static ArrayList Exmp01(int q)
        {
            Random rnd = new Random();
            ArrayList arr = new ArrayList();
            for (int i = 0; i < q; i++)
            {
                arr.Add(i);
            }
            //   arr.Add("ww"); // можно вывести, но не работать, таккак это не числовое значение

            return arr;
        }
        public static void RemoveElement(int i, int j, ref ArrayList arr)
        {
            arr.RemoveRange(i, j); //удаляет с по 
        }
        public static void AddElement(int i, ref ArrayList arr)
        {
            arr.Add(i);
        }
        public static void WriteCollection(ArrayList arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine("{0}\t {1}", item, item.GetType());

                if (item.GetType() == typeof(int))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("это инт");
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
            }
        }



    }
}
