using Bll.ReturnObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace Bll
{
    public class OrderProducts
    {
        DalContext _dalContext;
        public OrderProducts()
        {
            _dalContext = new(ConfigureSQL.options);
        }

        public void Add(int id,int amount)
        {
            OrderProduct product = _dalContext.OrderProducts.Where(p => p.Id == id).First();
            product.PickedAmount = amount;
            product.Picked = true;
            _dalContext.SaveChanges();
        }

        public OrderProductRO Get(int id) 
        {
            OrderProduct product = _dalContext.OrderProducts.Where(p => p.OrderId  == id & p.Picked == false).Include(m => m.product).First();
            OrderProductRO orderProduct = new OrderProductRO();
            orderProduct.Name = product.product.Name;
            orderProduct.Amount = product.Amount;
            orderProduct.Id = product.Id;
            return orderProduct;
        }
    }
}
