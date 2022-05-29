using CustomerProductClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerProductTests
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

        public Customer this[int i]
        {
            get
            {
                return customers[i];
            }
            set
            {
                customers[i] = value;
            }
        }

        public Customer this[string email]
        {
            get
            {
                foreach (Customer c in customers)
                {
                    if (c.Email == email)
                        return c;
                }
                return null;
            }
        }

         public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Add(string email, string firstName, int id, string lastName, string phone)
        {
            Customer c = new Customer(email, firstName, id, lastName, phone);
            customers.Add(c);
        }

        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }
        
        public static CustomerList operator +(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList operator +(Customer c, CustomerList cl)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList operator -(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }

        public static CustomerList operator -(CustomerList cl, int count)
        {
            for (int i = 1; i <= count; i++)
                cl.customers.RemoveAt(0);
            return cl;
        }

        public void ListCustomers()
        {
            customers = new List<Customer>();
        }
        
        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer c in customers)
            {
                output += c.ToString() + "\n";
            }
            return output;
        }
    }
}

