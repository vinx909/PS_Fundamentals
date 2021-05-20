using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace during_Lesson.DotNet
{
    internal class Customer : IComparable<Customer>
    {
        public string Firstname { get; set; }
        public string SurnamePrefix { get; set; }
        public string Surname { get; set; }

        public string FullName => Firstname + " " + SurnamePrefix + " " + Surname;

        public int CompareTo(Customer other)
        {
            if (other == null)
            {
                return -1;
            }
            return this.FullName.CompareTo(other.FullName);
        }

    }
}
