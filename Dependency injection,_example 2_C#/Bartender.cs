using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection__example_2_C_
{
    // Complete with another Objects
    //https://www.youtube.com/watch?v=Q5J8t89rZQA&t=600s
    public class Bartender
    {

        IDrinks drinks;
        public Bartender(IDrinks _drinks)
        {
            this.drinks = _drinks;
        }



        public void Prepare()
        {

            this.drinks.Prepare();


        }
    }
}
