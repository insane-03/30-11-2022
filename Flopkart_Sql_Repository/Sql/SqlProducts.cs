using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flopkart_Sql_Repository.Sql
{
    
        public class SqlProducts
        {
        
            public string? ProductName { get; set; }

            [Key]
            public int ProductId { get; set; }

            public int Quantity { get; set; }
        }
    

}
