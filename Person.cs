using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_Advance
{
    public abstract class Person
    {
        // fields
        private string name;
        private int age;
        private string address;
        private string phone;

        // get and set methods
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                    throw new
                        ArgumentException("Name length must be at lease 3 characters!");
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age must greater than 0!");
                age = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Address must greater than 2 characters!");
                address = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length < 10)
                    throw new ArgumentException("Phone number must be at least 10 number!");
                phone = value;
            }
        }

        // constructors
        public Person(string name, int age,
            string address, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Phone = phone;
        }

        public Person()
        {

        }
        public abstract void New();

        public virtual void Display()
        {
            Console.WriteLine("Information");
        }

    }
}
