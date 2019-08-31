using LittlePaktBookstore.Data;
using LittlePaktBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittlePaktBookstore.Services
{
    public class SqlOrdersRepository : IRepository<Order>
    {
        private LittlePacktBookStoreDbContex _context;

        public SqlOrdersRepository(LittlePacktBookStoreDbContex  context)
        {
            _context = context;
        }

        public bool Add(Order item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Order Item)
        {
            try
            {
                Order book = Get(Item.Id);
                if (book != null)
                {
                    _context.Remove(Item);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Edit(Order item)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            if (_context.Orders.Count(x => x.Id == id) > 0)
            {
                return _context.Orders.FirstOrDefault(x => x.Id == id);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders;
        }
    }
}
