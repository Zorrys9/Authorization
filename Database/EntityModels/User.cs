﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.EntityModels
{
    
    public class User
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string patronymic { get; set; }
        public int rolles { get; set; }

    }
}
