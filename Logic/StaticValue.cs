using Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Enums;

namespace Logic
{
    public static class StaticValue
    {
        public static int IdUser = 0;
        public static int RollUser = 0;
        public static UserContext db = new UserContext();
    }
}
