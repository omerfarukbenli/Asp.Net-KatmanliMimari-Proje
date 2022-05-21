using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class ProductFeature
    {
        //buna baseentity yapmadık, producta bağlı olduğu için
        //feature = özellik demek
        public int Id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; }
        //bir producta a ait olacağı için 
        //foreignkey
        public Product Product { get; set; }
    }
}
