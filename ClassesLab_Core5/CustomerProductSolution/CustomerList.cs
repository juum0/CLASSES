using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList
{
    public class CustomerList
    {
        private List<Customer> customers;


        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count
        {
            get
            {
                return customers.Count;
            }
        }

        public void Fill
        {
            customers = 
        }

        public void Save()
        {
            
        }

        public void Add(CustomerList customer)
        {
            customers.Add(customer);
        }

        public void Add(string email, string firstName, int id, string lastName, string phone)
        {
            CustomerList c = new Customer(email, firstName, id, lastName, phone)
            customers.Add(c);
        }

        public void Remove(CustomerList customer)
        {
            customers.Remove(customer);
        }














    }
}
