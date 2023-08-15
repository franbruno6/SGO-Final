using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SGO.Entitys
{
    public class productsEntity
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Provider { get; set; }
            public string Material { get; set; }
        }

    }
}
