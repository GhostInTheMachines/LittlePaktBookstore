using LittlePaktBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittlePaktBookstore.Services
{
    public class MockCarouselRepository : IRepository<Carousel>
    {
        List<Carousel> _carousels;
        public MockCarouselRepository()
        {
            _carousels = new List<Carousel>();
            _carousels.Add(new Carousel()
            {
                Id = 0,
                Title = "Discount books",
                Description = "Buy Lo, Sell High",
                imageURL = "bk-cat-01-400x250.png"
            });
            _carousels.Add(new Carousel()
            {
                Id = 1,
                Title = "Cheap books",
                Description = "Cheap crap you don't need, but you will buy it anyway.",
                imageURL = "bk-cat-02-400x250.png"
            });
            _carousels.Add(new Carousel()
            {
                Id = 2,
                Title = "Moderate books",
                Description = "You could find these anywhere, but you won't",
                imageURL = "bk-cat-03-400x250.png"
            });
        }
        public bool Add(Carousel item)
        {
            try
            {
                Carousel carousel = item;
                carousel.Id = _carousels.Max(x => x.Id) + 1;
                _carousels.Add(carousel);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Carousel item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Carousel item)
        {
            throw new NotImplementedException();
        }

        public Carousel Get(int id)
        {
            return _carousels.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Carousel> GetAll()
        {
            return _carousels.ToList();
        }
    }
}
