using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class User
    {
        private int id;
        private string name;
        private static int age;

        public User(int id, string name) 
        {
        this.id = id;
        this.name = name;
        }
        public int Id
        {
            get { return id; } 
            set { id = value; }
        } 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static int Age
        {
            get { return age; }
            set { age = value; }
        }
        public static void ChangeAge(int newAge)
        {
            age = newAge;
        }
        

    }
}
