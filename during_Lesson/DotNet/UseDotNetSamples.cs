using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace during_Lesson.DotNet
{
    public static class UseDotNetSamples
    {
        public static void SortACustomerCollection()
        {
            List<Customer> customers = new()
            {
                new Customer { Firstname = "Jan", SurnamePrefix = "de", Surname = "Boer" },
                new Customer { Firstname = "Klaas", SurnamePrefix = "de", Surname = "Broer" },
                null,
                new Customer { Firstname = "Jan", SurnamePrefix = "de", Surname = "Broer"},
                new Customer { Firstname = "Peter", SurnamePrefix = "de", Surname = "Beer" }
            };

            customers.ForEach((c) => { if (c != null) { Console.WriteLine($"Unsorted: {c.FullName}"); } else { Console.WriteLine("null"); } });

            customers.Sort();

            customers.ForEach((c) => { if (c != null) { Console.WriteLine($"Sorted default: {c.FullName}"); } else { Console.WriteLine("null"); } });

            customers.Sort(new SurnameComparer());

            customers.ForEach((c) => { if (c != null) { Console.WriteLine($"Sorted SurnameComparer: {c.FullName}"); } else { Console.WriteLine("null"); } });
        }
    }
}
