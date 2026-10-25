using System;
using System.Collections.Generic;
using System.Text;

namespace Week_2_practical
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private string phone;

        public int MemberId
        {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error:Member ID must be greater than 0.");
                }
            }
        }
        public string Name
        {
            get { return name; }  // get method
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error:Member name cannot contain numbers.");
                }
            }

        }
        public string Address
        {
            get { return address; }  // get method
            set { address = value; } // set method
        }
        public string Phone
        {
            get { return phone; }  // get method
            set { phone = value; } // set method
        }
        public Member(int memberId,string name, string address, string phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone: {Phone}");
        }
    }
}
