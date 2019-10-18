using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikksonori
{
    class Program
    {
        // <
        static void Main(string[] args)
        {
            var a = new Dictionary<string, string[]>();
            string[] b = { "elso", "masodik", "harmadik" };
            a.Add("szamok", b);
            foreach (var item in a)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]}");
            }



            //new Dictionary<string, string[]>();
            var dic = new Dictionary<string, string[]>();
            string[] st = { "cat", "pussy", "kitty" };
            dic.Add("cica", st);
            Console.WriteLine(dic["cica"][0]);

            foreach (KeyValuePair<string, string[]> kvp in dic)
            {
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"{kvp.Key} -> {item}");
                }
            }


            //new Dictionary<string[], string>();
            var dic2 = new Dictionary<string[], string>();
            string[] st2 = { "elso", "masodik", "harmadik" };
            dic2.Add(st2, "fasz");

            foreach (KeyValuePair<string[], string> kvp in dic2)
            {
                for (int i = 0; i < kvp.Key.Length; i++)
                {
                    Console.WriteLine(kvp.Key[i] + " " + kvp.Value);

                }
                /*
                foreach (var item in kvp.Key)
                {
                    Console.WriteLine($"{kvp.Key} -> {item}");
                }
                */
            }


            /*
             foreach (KeyValuePair<int, int> kvp in asz)
            {
                sw2.WriteLine(kvp.Key + "-->" + kvp.Value);
            }
             */

            Console.ReadKey();
        }
    }
}
