using basic_graphQL_api.Core.Entities;
using basic_graphQL_api.Infrastructure;

namespace basic_graphQL_api.API;

public class EmployeeQuery
{
    private readonly IEmployeeRepo _employeeRepo;

    public EmployeeQuery(IEmployeeRepo employeeRepo)
    {
        _employeeRepo = employeeRepo;
    }

    public IEnumerable<EmployeeEntity> GetAllEmployees()
    {
        return _employeeRepo.GetAllEmployees();
    }
}