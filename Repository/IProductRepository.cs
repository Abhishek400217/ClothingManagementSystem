using System.Collections.Generic;
using ClotheManagementSystem.Models;

namespace ClotheManagementSystem.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product GetById(int id);

        bool Insert(Product product);

        bool Update(Product product);

        bool Delete(int id);


    }
}