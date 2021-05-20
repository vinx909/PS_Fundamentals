using System.Collections.Generic;

namespace during_Lesson.DotNet
{
    class SurnameComparer : IComparer<Customer>
    {
        public int Compare(Customer customer, Customer other)
        {
            if(customer == null && other == null)
            {
                return 0;
            }
            else if(customer == null)
            {
                return -1;
            }
            else if(other == null)
            {
                return 1;
            }
            else
            {
                int toReturn = customer.Surname.CompareTo(other.Surname);
                if (toReturn == 0)
                {
                    return customer.Firstname.CompareTo(other.Firstname);
                }
                else
                {
                    return toReturn;
                }
            }
        }
    }
}
