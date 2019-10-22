using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Context;
using Database.EntityModels;
namespace Logic.Model
{
    public class AuthorizationProcess
    {
        public static int GetRollUser(string login, string password)
        {
            var user = StaticValue.db.User.Where(us => us.login == login && us.password == password);
            if (user.Count() > 0)
            {
                int rolles = user.FirstOrDefault().rolles;
                StaticValue.IdUser = user.FirstOrDefault().Id;
                return rolles;
            }
            else throw new Exception("Неверно введён логин или пароль");
        }

    }
}
