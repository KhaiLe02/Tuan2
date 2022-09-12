using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Account
    {
        private int AccountID;
        private string LastName;
        private string FirstName;
        private float Balance;

        public Account(int accountID, string lastName, string firstName, float balance)
        {
            AccountID = accountID;
            LastName = lastName;
            FirstName = firstName;
            Balance = balance;
        }

        public int AccountID1
        {
            get
            {
                return AccountID;
            }

            set
            {
                AccountID = value;
            }
        }

        public string LastName1
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public string FirstName1
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public float Balance1
        {
            get
            {
                return Balance;
            }

            set
            {
                Balance = value;
            }
        }
        public Account()
        {
        }
        public void Input()
        {
            Console.WriteLine("Nhap AccountID ");
            AccountID = int.Parse( Console.ReadLine());
            Console.WriteLine(" Nhap LastName");
            LastName = Console.ReadLine();
            Console.WriteLine("Nhap FirstName");
            FirstName = Console.ReadLine();
            Console.WriteLine("Nhap So Du");
            Balance = float.Parse( Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("AccountID: " + AccountID);
            Console.WriteLine("LastName: " + LastName);
            Console.WriteLine("FirstName: " + FirstName);
            Console.WriteLine("So Du: " + Balance);
           
        }
    }
}
