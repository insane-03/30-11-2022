using Flopkart_Sql_Repository.Interface;
using Flopkart_Sql_Repository;
using Flopkart_Sql_Service.Interface;
using Flopkart_Model;
using AutoMapper;
using Flopkart_Sql_Repository.Sql;

namespace Flopkart_Sql_Service.Implementation
{
    public class SqlProductService : ISqlProductService
    {
        private readonly ISqlProductRepository _sql_productRepository;

        private readonly IMapper _mapper;

        public SqlProductService(ISqlProductRepository productRepository, IMapper mapper)
        {
            _sql_productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductModel> Get()
        {
            List<SqlProducts> products = _sql_productRepository.GetP();
            var productsList = _mapper.Map<List<ProductModel>>(products);
            return productsList;


        }

        public ProductModel GetOne(int ProductId)
        {
            SqlProducts SqlProducts = _sql_productRepository.GetOneP(ProductId);
            ProductModel product = _mapper.Map<ProductModel>(SqlProducts);
            return product;
        }

        public ProductModel Add(ProductModel product)
        {
            _sql_productRepository.AddP(_mapper.Map<SqlProducts>(product));

            return product;
        }


        public ProductModel Change(ProductModel product, int ProductId)
        {
            _sql_productRepository.UpdateP(_mapper.Map<SqlProducts>(product), ProductId);
            return product;
        }

        public ProductModel Delete(int ProductId)
        {
            SqlProducts Sqlproduct = _sql_productRepository.DeleteP(ProductId);
            ProductModel product = _mapper.Map<ProductModel>(Sqlproduct);
            return product;
        }

        public int NoOf()
        {
            return _sql_productRepository.GetPCount();
        }

    }
}
