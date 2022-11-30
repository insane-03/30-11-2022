using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flopkart_Model;
using Flopkart_Sql_Repository.Sql;

namespace Flopkart_Sql_Repository.Interface
{
    public interface ISqlProductRepository
    {
        public List<SqlProducts> GetP();
        public SqlProducts AddP(SqlProducts product);
        public SqlProducts UpdateP(SqlProducts product, int id);
        public SqlProducts DeleteP(int id);

        public SqlProducts GetOneP(int ProductId);

        public int GetPCount();
    }
}
