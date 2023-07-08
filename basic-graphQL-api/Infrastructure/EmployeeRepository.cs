using basic_graphQL_api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace basic_graphQL_api.Infrastructure;

public interface IEmployeeRepo
{
    public IEnumerable<EmployeeEntity> GetAllEmployees();
}
public class EmployeeRepository : IEmployeeRepo
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public EmployeeRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public IEnumerable<EmployeeEntity> GetAllEmployees()
    {
        using (var dbContext = _dbContextFactory.CreateDbContext())
        {
            return dbContext.EmployeeEntities.ToList();
        }
    }
}
