using System;

namespace CustomerProductClasses
{
    public class Customer
    {
        //instance variable - all products get these
        private string elecMail;
        private string firsName;
        private int iDen;
        private string lasName;
        private string phoneNum;

        public Customer()
        {
            Email = "";
            FirstName = "";
            Id = 0;
            LastName = "";
            Phone = "";
        }

        public Customer(string email, string firstName, int id, string lastName, string phone)
        {
            Email = email;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
            Phone = phone;
        }

        public string Email
        {
            get
            {
                return Email;
            }

            set
            {
                elecMail = value;
            }
        }

        public string FirstName
        {
            get
            {
                return FirstName;
            }

            set
            {
                firsName = value;
            }
        }

        public int Id
        {
            get
            {
                return Id;
            }

            set
            {
                iDen = value;
            }
        }

        public string LastName
        {
            get
            {
                return LastName;
            }

            set
            {
                lasName = value;
            }
        }

        public string Phone
        {
            get
            {
                return Phone;
            }

            set
            {
                phoneNum = value;
            }
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !c1.Equals(c2);
        }

        public override string ToString()
        {
            return String.Format("Email: {0} First name: {1} id: {2} Last name: {3} Phone: {4}", elecMail, firsName, iDen, lasName, phoneNum);
        }
        public override int GetHashCode()
        {
            return 13 + 7 * Email.GetHashCode() +
                7 * FirstName.GetHashCode() +
                7 * Id.GetHashCode() +
                7 * LastName.GetHashCode() +
                7 * Phone.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
                return false;
            else
            {
                Customer other = (Customer)obj;
                return 
                    other.Email == Email &&
                    other.FirstName == FirstName &&
                    other.Id == Id &&
                    other.LastName == LastName &&
                    other.Phone == Phone;
            }
        }
    }

}
