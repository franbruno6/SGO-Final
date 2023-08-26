using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_SGO.Entitys.budgetEntity;
using static Final_SGO.Entitys.personEntity;

namespace Final_SGO.Entitys
{
    public class clientEntity
    {
        public class Client : Person
        {
            public string Adress { get; set; }
            public string Phone { get; set; }
            public List<Budget> Budgets { get; set; }
        }
    }
}
