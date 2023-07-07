using basic_graphQL_api.Core.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace basic_graphQL_api.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<EmployeeEntity> EmployeeEntities { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var faker = new Faker<EmployeeEntity>()
            .RuleFor(e => e.FirstName, f => f.Name.FirstName())
            .RuleFor(e => e.SecondName, f => f.Name.LastName())
            .RuleFor(e => e.Position, f => f.Name.JobTitle());

        var employees = new List<EmployeeEntity>();

        for (var i = 1; i <= 100; i++)
        {
            var employee = faker.Generate();
            employee.Id = i; // Explicitly set the Id value.
            employees.Add(employee);
        }

        modelBuilder.Entity<EmployeeEntity>().HasData(employees);
    }


}