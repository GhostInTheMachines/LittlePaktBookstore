using LittlePaktBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittlePaktBookstore.Services
{
    public class MockBooksRepository : IRepository<Book>
    {
        List<Book> _books;
        public MockBooksRepository()
        {
            _books = new List<Book>()
            {
                new Book()
                {
                    Id = 0,
                    Title = "Pakt SUX",
                    Description = "All of the things you do not want to see in a publisher.",
                    Author = "Dennis Kimble",
                    PublishDate = "July, 2018",
                    Price = 39.01,
                    image = "book-placeholder-Blue-569x364.png"
                },
                new Book()
                {
                    Id = 1,
                    Title = "Go Fuck yourself Pakt",
                    Description = "Funny idiosims about Pakt",
                    Author = "Tone Loc",
                    PublishDate = "June, 2019",
                    Price = 29.01,
                    image = "book-placeholder-Grn-569x364.png"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Die dirt bag",
                    Description = "Happy thoughts for disgruntled employees.",
                    Author = "Ronnie Rahman",
                    PublishDate = "Feb, 2018",
                    Price = 19.01,
                    image = "book-placeholder-Red-569x364.png"
                }
            };
        }
        public bool Add(Book item)
        {
            try
            {
                Book book = item;
                book.Id = _books.Max(x => x.Id) + 1;
                _books.Add(item);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Book item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            return _books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books.ToList();
        }
    }
}
