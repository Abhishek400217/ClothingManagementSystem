using System.Collections.Generic;
using ClotheManagementSystem.Models;

namespace ClotheManagementSystem.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetAll();

        Order GetById(int id);

        bool Insert(Order order);

        bool Update(Order order);

        bool Delete(int id);
    }
}