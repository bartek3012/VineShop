using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;

namespace VineShop.Models
{
    /// <summary>
    /// Klasa do połączenia z tabelami baz danych 
    /// </summary>
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("ConnectionString")
        {

        }
        //Tabele baz danych
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Sweetness> Sweetnesses { get; set; }
        public DbSet<Entities.Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vine> Vines { get; set; }
    }
}
