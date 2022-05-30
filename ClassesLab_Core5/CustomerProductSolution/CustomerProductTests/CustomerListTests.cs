using System;
using CustomerProductClasses;

namespace CustomerProductTests
{
    public class CustomerListTests
    {
        //I don't know what this error is or how to fix it, otherwise should run fine
        static void Main(string[] args)
        {
            TestCustomerListAddCustomer();
            TestCustomerListAddConstructor();
            TestCustomerListFill();
            TestCustomerListListCustomers();
            TestCustomerListRemove(); 
        }



        static void TestCustomerListAddCustomer()
        {
            CustomerList list = new CustomerList();
            Customer c1 = new Customer();
            Console.WriteLine("Count.  Expecting 0. " + list.Count);
            Console.WriteLine("Testing customer list add");
            list.Add(c1);
            Console.WriteLine("Count.  Expecting 1. " + list.Count);
            Console.WriteLine("ToString.  Expect c1. " + list.ToString());
            Console.WriteLine();
        }
        static void TestCustomerListAddConstructor()
        {
            CustomerList list = new CustomerList();
            list.Add ("test@mail.com", "first", 1, "last", "phonenumber");
            Console.WriteLine("Overloaded constructor.  Expecting test@mail.com, first, 1, last, phonenumber: " + list.ToString());
            Console.WriteLine();
        }

        /*
        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer("test@mail.com", "first", 1, "last", "phonenumber");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + c1.ToString());
            Console.WriteLine("Overloaded constructor.  Expecting mbox@gmail.com", "stan", 2, "marsh", "phonenumber " + c2.ToString());
            Console.WriteLine();
        }
        */
        static void TestCustomerListFill()
        {
            CustomerList list = new CustomerList();
            list.Fill();
            Console.WriteLine("Testing Fill");
            Console.WriteLine("I dont know how fill works" + list.ToString());
            Console.WriteLine();
        }

        static void TestCustomerListListCustomers()
        {
            CustomerList list = new CustomerList();
            Console.WriteLine("Testing ListCustomers");
            list.ListCustomers();
            Console.WriteLine();
        }

        static void TestCustomerListRemove()
        {
            CustomerList list = new CustomerList();
            Customer c1 = new Customer("test@mail.com", "first", 1, "last", "phonenumber");
            list.Add(c1);
            Console.WriteLine("testing remove. expected count 1: " + list.Count);
            list.Remove(c1);
            Console.WriteLine("customer removed. expected count 0: " + list.Count);
            Console.WriteLine();
        }


    }
}

