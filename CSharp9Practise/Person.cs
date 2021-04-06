using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9Practise
{
    record Person
    {
        protected Person(Person original)
        {
            this.Name = original.Name;
            this.Age = original.Age;
        }

        public Person(int Age, string Name)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void Deconstruct(out string Name, out int Age)
        {
            Name = this.Name;
            Age = this.Age;
        }

        public string Name { get; init; }
        public int Age { get; init; }
    }
}
