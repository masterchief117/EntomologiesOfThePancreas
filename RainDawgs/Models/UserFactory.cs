﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseBallClub.UserFactory
{
    public abstract class UserFactory
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string role { get; set; }
    }
}
