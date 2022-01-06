using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Administrator
{
    class AdministratorModel
    {
        public string username { get; set; }
        public string password { get; set; }

        public AdministratorModel(string username, string password)
        {
            this.username = username;
            this.password = password;
            
        }
    }
}
