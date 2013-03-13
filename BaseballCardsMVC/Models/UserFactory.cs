using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseballCardsMVC.Models
{
    public abstract class UserFactory
    {
        public string username {get; set;}
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string role { get; set; }
    }

    public class Region {
        public int id { get; set; }
        public string name { get; set; }
        public decimal discountRate {get; set;}
    }

    public abstract class Store {
        public int id { get; set; }
        public int regionId { get; set; }
        public decimal discountRate { get; set; }
    }

    public class HRManager : UserFactory { }

    public class SuperAdmin : UserFactory { }
    public class TechAdmin : UserFactory { }
    public class RegionalManager : UserFactory {
        public int regionId { get; set; }
    }

    public class StoreManager : UserFactory {
        public int storeId { get; set; }
    }

    public class Member : UserFactory {
        public int regionId { get; set; }
    }
    public class Dependent: UserFactory {
        public int owningMemberId { get; set; }
    }
}