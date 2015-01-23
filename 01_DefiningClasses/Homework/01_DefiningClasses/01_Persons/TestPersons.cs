using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestPersons
{
    static void Main()
    {
        Person person1 = new Person("Peshko", 28, "asd@bfk");
        Person person2 = new Person("Kacko", 28);
        Person person3 = new Person("Jujo", 28, "jjj@asd");
        Person person4 = new Person("zzz", 28);

        Console.WriteLine(person1);
        Console.WriteLine(person2);
        Console.WriteLine(person3);
        Console.WriteLine(person4);
    }
}

