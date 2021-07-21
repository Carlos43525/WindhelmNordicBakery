using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindhelmNordicBakery.Models.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
