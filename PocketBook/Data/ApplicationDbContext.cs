using Microsoft.EntityFrameworkCore;
using PocketBook.Models;

namespace PocketBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        //the db set prop will tell ef core that we have 
        // a table that needs to be  careated if doesent exists
        public virtual DbSet<User> Users {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
    }
}