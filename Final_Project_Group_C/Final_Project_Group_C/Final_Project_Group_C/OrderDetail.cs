using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project_Group_C
{
    public class Order
    {
        private Customer customerInfo;
        private Cone[] conesOrdered = new Cone[10];
        private int currentConeIndex;

        public Order()
        {
            currentConeIndex = 0;
        }
        public int CurrentConeIndex
        {
            get { return currentConeIndex; }
            set { currentConeIndex = value; }
        }

        public Customer CustomerInfo
        {
            get
            {
                return customerInfo;
            }
            set
            {
                customerInfo = value;
            }
        }
        public int numCones()
        {
            return CurrentConeIndex;
        }
        public Cone getCone(int i)
        {
            return conesOrdered[i];
        }
        public void addCone(Cone c)
        {
            conesOrdered[CurrentConeIndex] = c;
            CurrentConeIndex += 1;
        }
        public double getTotalPriceForOrders()
        {
            double total = 0.0;
            for (int i = 0; i < CurrentConeIndex; i++)
            {
                total += getCone(i).getConePrice();
            }
            return total;
        }
    }
}
