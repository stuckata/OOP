using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GalacticGPS
{
    public class GalacticGPSTest
    {
        static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
            Location mars = new Location(25.046785, 54.870097, Planet.Mars);
            Console.WriteLine(mars);
        }
    }
}
