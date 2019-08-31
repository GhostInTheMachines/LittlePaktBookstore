using LittlePaktBookstore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittlePaktBookstore.Data
{
    public class LittlePacktBookStoreDbContex:DbContext
    {
        public LittlePacktBookStoreDbContex(DbContextOptions options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
