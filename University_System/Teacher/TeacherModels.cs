using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Teacher
{
    class TeacherModels
    {
        public int tID { get; set; }
        public string fullName { get; set; }
        public string username { get; set; }
        public string password { get; set; }

public TeacherModels(string username, string fullName)
    {
        this.username = username;
        this.fullName = fullName;
        
    }
    }
    
}
