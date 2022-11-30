using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //List<Product> GetAll();
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
        //List<Product> GetAllByCategoryId(int categoryId);//ürünleri kategoriye göre filtreleme
        //örnek olara bir e-ticaret sitesinde filtreleme tuşuna bastığımızda çalışan kod parçacığıdır..!
        List<ProductDetailDto> GetProductDetails();
    }
}
