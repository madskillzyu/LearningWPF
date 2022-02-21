using System;
using System.Collections.Generic;
using System.Text;

namespace WPFTry1.ViewModels
{
    public class PersonViewModel
    {
       
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }



    }
}
