using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
        : this(name, age, null)
    {
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
            {
                throw new ArgumentException("You should enter a valid email.");
            }
            this.email = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    
    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Trim() == "")
            {
                throw new ArgumentException("The name should not be null or empty.");
            }
            if (value.Length >= 100)
            {
                throw new ArgumentOutOfRangeException("The name must be in range [1...100] characters.");
            }
            this.name = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Person name: {0}; Person age: {1}; Email: {2}", this.Name, this.Age, 
            this.Email ?? "Not specified" );
    }
}

