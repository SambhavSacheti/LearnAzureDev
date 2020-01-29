using Microsoft.EntityFrameworkCore;
using CommandsAPI.Models;

namespace CommandsAPI.Data
{
    public class CommandsAPIContext : DbContext
    {
        public CommandsAPIContext(DbContextOptions<CommandsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}