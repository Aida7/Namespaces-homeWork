using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Person
    {
        private int id;
        private int namber;
        private string name;
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return id;
        }
        public void SetNamber(int nam)
        {
            this.namber = nam;
        }
        public int GetNamber()
        {
            return namber;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}
