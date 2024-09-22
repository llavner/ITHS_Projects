using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Read_only_property_FullName
{
    class Person
    {

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
            
        }

    }
}
