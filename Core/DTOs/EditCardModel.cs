using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{   
    public class EditCardModel
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int CVV { get; set; }
        public DateTime ExpireDate { get; set; }
    }   
}   
