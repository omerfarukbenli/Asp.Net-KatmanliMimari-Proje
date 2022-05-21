using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public abstract class BaseDto
    { //update time ı istemiyoruz o yüzden basedto yaptık
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
