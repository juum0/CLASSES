using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        //instance variable - all products get these
        private string email;
        private string firstName;
        private int id;
        private string lastName;
        private string phone;


        public Customer(string email, string firstName, int id, string lastName, string phone)
        {
            userMail = email;
            First = firstName;
            userId = id;
            last = lastName;
            phoneNum = phone;
        }

        private string userMail
        {
            get
            {
                return userMail;
            }

            set
            {
                email = value;
            }
        }

        public string First
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        private int userId
        {
            get
            {
                return userId;
            }

            set
            {
                id = value;
            }
        }

        private string last
        {
            get
            {
                return lastName;
            }

            set
            {
                last = value;
            }
        }

        private string phoneNum
        {
            get
            {
                return phoneNum;
            }

            set
            {
                phone = value;
            }
        }


        public override string ToString()
        {
            return String.Format("Email: {0} First name: {1} id: {2} Last name: {3} Phone: {4}", email, firstName, id, lastName, phone);
        }

    }
}
