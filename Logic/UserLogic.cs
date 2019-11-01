using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Database.EntityModels;
namespace Logic.Model
{
    public class UserLogic
    {

        public static int Authorization(string login, string password)
        {
            var user = SecurityContext.db.User.Where(us => us.login == login && us.password == password);
            if (user.Count() > 0)
            {
                int rolles = user.FirstOrDefault().rolles;
                SecurityContext.IdUser = user.FirstOrDefault().Id;
                return rolles;
            }
            else throw new Exception("Неверно введён логин или пароль");
        }


        public static void Registration(UserRegistrationModel newUser)
        {
                User NewUser = new User
                {
                    firstname = newUser.FirstName,
                    lastname = newUser.LastName,
                    patronymic = newUser.Patronymic,
                    login = newUser.Login,
                    password = Verification(newUser.Password),
                    rolles = newUser.Rolle                
                };

                SecurityContext.RollUser = newUser.Rolle;
                SecurityContext.db.User.Add(NewUser);
                SecurityContext.db.SaveChanges();
        }


       static string Verification(string password)
        {
            if (password.Length > 8)
            {
                var value = new Regex(@"(.+[A-Z])");

                if (value.IsMatch(password))
                {

                    value = new Regex(@"(.+[a-z])");

                    if (value.IsMatch(password))
                    {

                        value = new Regex(@"(.+[!,@,#,№,$,%,;,&,*])");

                        if (value.IsMatch(password))
                        {

                            return password;

                        }
                        else throw new Exception("Пароль должен содержать как минимум 1 спец. символ!");

                    }
                    else throw new Exception("Пароль должен содержать как минимум 1 прописные буквы!!");

                }
                else throw new Exception("Пароль должен содержать как минимум 1 строчные буквы!");


            }
            else throw new Exception("Пароль слишком короткий!");

        }


    }
}
