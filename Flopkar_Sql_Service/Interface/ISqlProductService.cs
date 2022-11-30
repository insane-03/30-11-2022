using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flopkart_Model;

namespace Flopkart_Sql_Service.Interface
{
    public interface ISqlProductService
    {

        public List<ProductModel> Get();

        public ProductModel Add(ProductModel product);

        public ProductModel Delete(int ProductId);


        public ProductModel GetOne(int ProductId);

        public ProductModel Change(ProductModel product, int ProductId);

        public int NoOf();
        
    }
}
