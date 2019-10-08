using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3
{
    class Account
    {
        private int accountld;
        private int balance;
        private string firstname;
        private string gender;
        private string lastname;

        public int Accountld { get => accountld; set => accountld = value; }
        public int Balance { get => balance; set => balance = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
