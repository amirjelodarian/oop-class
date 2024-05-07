using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        
        public Person(int _age)
        {
            age = _age;            
        }
        public Person(int age, string name) : this(age)
        {
            this.age = age;
            this.Name = name;
        }
        public Person() : this(5)
        {
            
        }
        public int Id { get; set; }
        public int age { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
