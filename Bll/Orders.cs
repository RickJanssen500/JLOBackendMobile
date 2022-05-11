using Bll.ReturnObjects;
using DAL.Data;
using DAL.Models;

namespace Bll
{
    public class Orders
    {
        DalContext _dalContext;
        public Orders()
        {
            _dalContext = new(ConfigureSQL.options);
        }

        public void CompleteOrder(int id)
        {
           Order order = _dalContext.Orders.Where(p => p.Id == id).First();
           order.Picked = true;
           _dalContext.SaveChanges();
        }

        public IEnumerable<OrderRO> GetAllOrders()
        {
            List<Order> items = _dalContext.Orders.Where(p => p.Complete == true).ToList();
            List<OrderRO> orders = new List<OrderRO>();
            foreach(Order item in items)
            {
                OrderRO order = new OrderRO();
                order.Pickup = item.pickup;
                order.Id = item.Id;
                orders.Add(order);
            }
            return orders; 
        }    
    }
}