using LittlePaktBookstore.Data;
using LittlePaktBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittlePaktBookstore.Services
{
    public class SqlBooksRepository : IRepository<Book>
    {
        private LittlePacktBookStoreDbContex _context;

        public SqlBooksRepository(LittlePacktBookStoreDbContex context)
        {
            _context = context;
        }
        public bool Add(Book item)
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

        public bool Delete(Book Item)
        {
            try
            {
                Book book = Get(Item.Id);
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

        public bool Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            if (_context.Books.Count(x=> x.Id == id)>0)
            {
                return _context.Books.FirstOrDefault(x => x.Id == id);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;        
        }
    }
}
