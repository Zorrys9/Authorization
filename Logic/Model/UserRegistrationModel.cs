using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class UserRegistrationModel
    {

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Patronymic { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public int Rolle { get; set; }
    }
}
