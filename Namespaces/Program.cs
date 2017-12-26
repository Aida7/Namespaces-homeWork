using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Namespaces;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        { Person person = new Person();
            Console.WriteLine("id =");
            int id, namber;
            string name;
            int.TryParse(Console.ReadLine(), out id);
            person.SetId(id);

            Console.WriteLine("namber =");
            int.TryParse(Console.ReadLine(), out namber);
            person.SetNamber(namber);

            Console.WriteLine("name =");
            name = Console.ReadLine();
            person.SetName(name);

            person.GetId();
            Class class1 = new Class();
            Class.ToDo(person);
            Console.ReadLine();
        }
    }
}
