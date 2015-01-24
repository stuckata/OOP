using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestPcCatalog
{
    static void Main()
    {
        List<Computer> computers = new List<Computer>()
        {
            new Computer
            (
                "Asus ROG PC", 
                new List<Component>()
                {
                    new Component("MB Asus H97", "Supports up to 32GB DDR3 2400", 120.00m),
                    new Component("CPU Intel i7", 290.00m),
                    new Component("RAM 2x8GB", "DDR3 1866 MHz", 160.00m),
                    new Component("VGA Asus GTX970", "4GB GDDR5",350.00m),
                    new Component("HDD 2TB", 120.00m)
                }
            ),
             new Computer
            (
                "Asus Business PC", 
                new List<Component>()
                {
                    new Component("MB Asus B85", "Supports up to 16GB DDR3 1600", 60.00m),
                    new Component("CPU Intel Pentium G3220", 65.00m),
                    new Component("RAM 4GB", "DDR3 1600 MHz", 45.00m),
                    new Component("HDD 500GB", 65.00m),
                }
            )
        };

        foreach (var computer in computers)
        {
            Console.WriteLine(computer);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

