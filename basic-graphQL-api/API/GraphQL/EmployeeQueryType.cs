using basic_graphQL_api.API.GraphQL.Types;

namespace basic_graphQL_api.API.GraphQL;

public class EmployeeQueryType : ObjectType<EmployeeQuery>
{
    protected override void Configure(IObjectTypeDescriptor<EmployeeQuery> descriptor)
    {
        descriptor.Field(q => q.GetAllEmployees()).Type<EmployeeType>();
    }
}
