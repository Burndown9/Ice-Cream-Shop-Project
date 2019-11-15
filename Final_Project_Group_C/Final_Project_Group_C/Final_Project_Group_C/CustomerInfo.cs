using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Project_Group_C
{
    public class Customer: IComparable<Customer>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CustomerID { get; set; }
        public override string ToString()
        {
            return FirstName + ' ' + LastName + ' ' + CustomerID;
        }
        public int CompareTo(Customer other)
        {
            return this.CustomerID.CompareTo(other.CustomerID);
        }
    }
}
