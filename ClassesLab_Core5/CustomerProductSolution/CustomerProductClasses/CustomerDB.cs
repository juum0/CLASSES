﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CustomerProductClasses
{
    public class CustomerList
    {
        
        private const string Path = @"..\..\..\data\Customers.xml";
        private  List<Customer> customers = new List<Customer>();
        public static List<Customer> GetCustomers()
        {
            // create the list
            List<Customer> customers = new List<Customer>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Customer node
            if (xmlIn.ReadToDescendant("Customer"))
            {
                // create one Product object for each Product node
                do
                {
                    Customer customer = new Customer();
                    xmlIn.ReadStartElement("Customer");
                    customer.Id = xmlIn.ReadElementContentAsInt();
                    customer.Email = xmlIn.ReadElementContentAsString();
                    customer.FirstName = xmlIn.ReadElementContentAsString();
                    customer.LastName = xmlIn.ReadElementContentAsString();
                    customer.Phone = xmlIn.ReadElementContentAsString();
                    customers.Add(customer);
                }
                while (xmlIn.ReadToNextSibling("Customer"));
            }

            // close the XmlReader object
            xmlIn.Close();

            return customers;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Customers");

            // write each product object to the xml file
            foreach (Customer customer in customers)
            {
                xmlOut.WriteStartElement("Customer");
                xmlOut.WriteElementString("Id", customer.Id.ToString());
                xmlOut.WriteElementString("Email", customer.Email);
                xmlOut.WriteElementString("FirstName", customer.FirstName);
                xmlOut.WriteElementString("LastName", customer.LastName);
                xmlOut.WriteElementString("Phone", customer.Phone);
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }

        public void ListCustomers()
        {
            customers = new List<Customer>();
        }

        public void Fill()
        {
            customers = CustomerList.GetCustomers();
        }

        public void Save()
        {
            CustomerList.SaveCustomers(customers);
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

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public static CustomerList operator +(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        public static CustomerList operator -(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }



    }
}
