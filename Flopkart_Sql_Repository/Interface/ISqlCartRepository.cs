using Flopkart_Sql_Repository.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flopkart_Sql_Repository.Interface
{
    public interface ISqlCartRepository
    {
        public SqlProducts BuyItems(SqlProducts products);
    }
}
