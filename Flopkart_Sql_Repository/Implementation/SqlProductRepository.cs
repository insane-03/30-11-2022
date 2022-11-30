using Flopkart_Model;
using Flopkart_Sql_Repository.Interface;
using Flopkart_Sql_Repository.Sql;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flopkart_Sql_Repository.Implementation
{
    public class SqlProductRepository : ISqlProductRepository
    {
        public readonly SqlDBContext _sqlDBContext;
        
        public SqlProductRepository(SqlDBContext sqlDBContext)
        {
            _sqlDBContext = sqlDBContext;
           
        }

        public List<SqlProducts> GetP()
        {
            
            return _sqlDBContext.SqlProducts.ToList();
        }

        public SqlProducts GetOneP(int id)
        {
            var response = _sqlDBContext.SqlProducts.SingleOrDefault(x => x.ProductId == id);
            return response;
        }

        public SqlProducts AddP(SqlProducts product)
        {
            var response = _sqlDBContext.SqlProducts.Add(product);
            _sqlDBContext.SaveChanges();
            return response.Entity;
        }

        public SqlProducts UpdateP(SqlProducts product, int id)
        {
            var response = _sqlDBContext.SqlProducts.FirstOrDefault(x => x.ProductId == id);
            response.ProductName = product.ProductName;
            //response.ProductId = product.ProductId;
            response.Quantity = product.Quantity;
            _sqlDBContext.SaveChanges();
            return response;
        }

        public SqlProducts DeleteP(int id)
        {
            var response = _sqlDBContext.SqlProducts.SingleOrDefault(x => x.ProductId == id);
            _sqlDBContext.Remove(response);
            _sqlDBContext.SaveChanges();
            return response;
        }

        public int GetPCount()
        {
            return (int)_sqlDBContext.SqlProducts.Count(_ => true);
        }
    }
}
