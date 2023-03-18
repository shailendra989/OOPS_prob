using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class Encap
    {
        private string firstName;
        private string lastName;
        private string email;
        private string city;


        public void SetfirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getFirstName()
        {
            return this.firstName;
        }

        public void SetlastName(String lastName) { 
            this.lastName = lastName;
        }
        public String getLastName()
        {
            return this.lastName;
        }
        public void Setemail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return this.email;
        }
        
        public string getCity()
        {

            return this.city;
        }
        public void setCity(String city)
        {
            this.city = city;
        }


    }
}
