using System;

namespace ACM.BL
{
    public class Customer
    {
        public string _lastName;

        public String FirstName { get; set; }
        public String EmailAddress { get; set; }
        public int CustomerId { get; private set; }
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

        public String FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }

     

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;
            return isValid;

        }


    }
}
