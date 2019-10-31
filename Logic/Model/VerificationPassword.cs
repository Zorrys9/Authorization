using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class VerificationPassword
    {
        public static string Verification(string password)
        {
            if (password.Length > 8)
            {
                var value = new Regex(@"(.+[A - Z])");
                if (value.IsMatch(password))
                {
                    value = new Regex(@"(.+[a-z])");
                    if (value.IsMatch(password))
                    {
                        value = new Regex(@"(.+[!,@,#,№,$,%,;,&,*,  ])");
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
