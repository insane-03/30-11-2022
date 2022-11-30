using Flopkart_Model;
using Flopkart_Sql_Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flopkart_Sql_Service.Implementation
{
    public class SqlCartService : ISqlCartService
    {
        public ProductModel Select(ProductModel product) 
        { 
            return product; 
        }
    }
}
