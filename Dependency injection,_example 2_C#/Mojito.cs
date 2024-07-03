using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection__example_2_C_
{
    public class Mojito : IDrinks
    {
        public void Prepare()
        {
            Console.WriteLine("Making Mojito");

        }
    }
}
