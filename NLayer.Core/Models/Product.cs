using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        //category id bir foreign key
        //bire çok ilişki olduğu için
        public Category Category { get; set; }
        // her productın bir categorysi vardır
        public ProductFeature ProductFeature { get; set; }
    }
}
 