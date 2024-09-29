using Microsoft.EntityFrameworkCore;
using TraversalApi.DAL.Entities;

namespace TraversalApi.DAL.Context
{
    public class VisitorContext :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ARDACIMEN\\SQLEXPRESS;initial Catalog=TraversalApiProject;integrated Security=true;");

        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
