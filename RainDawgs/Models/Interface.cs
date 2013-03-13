using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseBallClub.Interface
{
    interface IUser
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string role;
    }

    interface IRegion
    {
        private int regionId;
    }
}
