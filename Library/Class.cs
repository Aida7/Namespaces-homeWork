using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Class
    {
        private int Id { get; set; }
        static string Name { get; set;}
        public static void ToDo(Person name)
        {
            Console.WriteLine("id {0}", name.GetId());
            Console.WriteLine("id {0}", name.GetNamber());
            Console.WriteLine("id {0}", name.GetName());
        }
    }
}
