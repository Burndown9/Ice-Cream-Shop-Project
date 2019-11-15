using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project_Group_C
{
    public class Supercone : Cone
    {
        private double cost = 0.50;

        public override double getConePrice()
        {
            return base.getConePrice() + cost;
        }
    }
}
