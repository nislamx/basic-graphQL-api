using basic_graphQL_api.Core.Entities;

namespace basic_graphQL_api.Infrastructure;

public interface IEmployeeRepo
{
    public IEnumerable<EmployeeEntity> GetAllEmployees();
}
public class EmployeeRepository: IEmployeeRepo
{
    private readonly ApplicationDbContext _dbContext;

    public EmployeeRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<EmployeeEntity> GetAllEmployees()
    {
        return _dbContext.EmployeeEntities;
    }
}