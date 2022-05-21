using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public abstract class BaseEntity
    {//her bir entityde bu üç alan olacak
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate{ get; set; } //sonradan güncellenecek önce boş olabilir
    }
}
