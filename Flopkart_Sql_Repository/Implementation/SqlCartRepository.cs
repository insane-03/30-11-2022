using Flopkart_Sql_Repository.Interface;
using Flopkart_Sql_Repository.Sql;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flopkart_Sql_Repository.Implementation
{
    public class SqlCartRepository : ISqlCartRepository
    {
        private readonly SqlDBContext _dbContext;

        public SqlCartRepository(SqlDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SqlProducts BuyItems(SqlProducts products)
        {
            var id = products.ProductId;

            //var productData = _dbContext.SqlProducts.Find(x => x.ProductId == id && x.ProductName == products.ProductName).FirstOrDefault();
            //if (productData != null)
            //{
            //    productData.Quantity = (productData.Quantity - products.Quantity);
            //    _dbContext.SqlProducts.ReplaceOne(product => product.ProductId == products.ProductId, productData);
            //    return productData;
            //}

            return products;


        }
    }
}
