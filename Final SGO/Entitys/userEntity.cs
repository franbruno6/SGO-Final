using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_SGO.Entitys.personEntity;

namespace Final_SGO.Entitys
{
    public class userEntity
    {
        public class User : Person
        {
            public string UserName { get; set; }
            private string Password { get; set; }
        }
    }
}
