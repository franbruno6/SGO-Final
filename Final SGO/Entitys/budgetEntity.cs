using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SGO.Entitys
{
    public class budgetEntity
    {
        public class Budget
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public decimal FinalPrice { get; set; }
            public int IdClient { get; set; }
            public string Adress { get; set; }
            public string Comment { get; set; }
        }
    }
}
