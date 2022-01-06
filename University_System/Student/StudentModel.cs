using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace University_System
{
    class StudentModel
    {
        public int NAID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int dob { get; set; }
        public int mobile { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string semester { get; set; }
        public string program { get; set; }
       // public string group { get; set; }
        public string duration { get; set; }
        public string address { get; set; }
      
        public StudentModel(string username, string firstName, string lastName)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

}
