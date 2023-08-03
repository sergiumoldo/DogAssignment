using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dog
{
    private int age;
    private string name;
    public Dog(string name, int age)
    {
       Name = name;
       Age = age;
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            if(value.Length <= 2)
            {
                throw new ApplicationException("Name must be longer than 2 characters");
            }
            this.name = value;

        }
    }
    public int Age 
    { 
        get { return this.age; }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Age must be higher than 0 ");
            }

            if (value > 100)
            {
                throw new ApplicationException("Age must be lower than 100 ");
            }

            this.age = value;

        } 
    }
}


