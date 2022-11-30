using Flopkart_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flopkart_Sql_Service.Interface
{
    public interface ISqlCartService
    {
        public ProductModel Select(ProductModel product);
    }
}
