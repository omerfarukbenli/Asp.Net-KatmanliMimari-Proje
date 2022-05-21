using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Category:BaseEntity
    {
        //Id, Createtime, UpdateTime oradan gelecek
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        //category daha geniş olduğu için
        //category nin birden fazla productı olabilir
         
    }
}
