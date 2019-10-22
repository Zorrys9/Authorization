using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.EntityModels;
using Database.Context;
using Logic.Enums;
namespace Logic.Model
{
    public class RegistrationProcess
    {
        public static bool SaveUser(string lastname, string firstname, string patronymic, string login, string password, int roll)
        {
            try
            {
                User NewUser = new User { firstname = firstname, lastname = lastname, patronymic = patronymic, login = login, password = password, rolles = roll };
                StaticValue.RollUser = roll;
                StaticValue.db.User.Add(NewUser);
                StaticValue.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
