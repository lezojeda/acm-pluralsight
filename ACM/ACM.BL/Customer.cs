using System.Collections.Generic;

namespace ACM.BL
{
   public class Customer
   {
        public Customer()
        {   
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }

        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
   
        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress);
        }

        public Customer Retrieve(string customerId)
        {
            return new Customer();
        }

        public List<Customer> RetrieveAllCustomers()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
