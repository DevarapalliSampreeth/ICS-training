//4. Create a simple Stationery application to add items and display added items using Generic List collections

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class program4
    {
        public static void Main(string[] args)
        {
            List<string> items = new List<string>();
            items.Add("pen");
            items.Add("pencil");
            List<string> newitems = new List<string>();
            newitems.Add("parker");
            newitems.Add("scale");
            items.AddRange(newitems);
            Console.WriteLine("---added items using Generic List collection---");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}