using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductUpdateDto //diğerlerinde updatecreated gelmesin diye base dto yaptık, bunu sadece entitydeki update için yapıyoruz
    {                             //sınırsız farklı dto yapılabilir, her bir sayfaya farklı dto yapılabilir
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
