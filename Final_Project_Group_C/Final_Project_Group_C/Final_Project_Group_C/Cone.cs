using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project_Group_C
{
    public class Cone
    {
        private double costScoop = 0.50;
        private double costCone = 0.75;
        public choice coneChoice { get; set; }
        public flavor coneFlavor { get; set; }
        public coneType typeOfCone { get; set; }
        public int numScoop { get; set; }

        public Cone()
        {
            coneChoice = choice.iceCream;
            coneFlavor = flavor.plain;
            typeOfCone = coneType.GottaHaveit;
            numScoop = 3;
        }
        public virtual double getConePrice()
        {
            return costCone + (costScoop * numScoop);
        }

    }
    public enum choice
    {
        iceCream,
        yogurt
    }
    public enum flavor
    {
        plain,
        CoffeeLover,
        FrenchVanilla
    }
    public enum coneType
    {
        Likeit,
        Loveit,
        GottaHaveit
    }
}
