using basic_graphQL_api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace basic_graphQL_api.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<EmployeeEntity> EmployeeEntities { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

}