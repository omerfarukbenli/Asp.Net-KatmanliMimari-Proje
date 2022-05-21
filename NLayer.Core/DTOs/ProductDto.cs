using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductDto:BaseDto //sonra sadece ikisi gelsin diye base dto yu ekliyoruz
    {
        //baseentityyi yazmıyoruz çünkü update time ı istemiyoruz
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
