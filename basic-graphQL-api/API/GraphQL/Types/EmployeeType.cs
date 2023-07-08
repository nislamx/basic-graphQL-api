using basic_graphQL_api.Core.Entities;

namespace basic_graphQL_api.API.GraphQL.Types;

public class EmployeeType : ObjectType<EmployeeEntity>
{
    protected override void Configure(IObjectTypeDescriptor<EmployeeEntity> descriptor)
    {
        descriptor.Field(e => e.Id).Type<NonNullType<IdType>>();
        descriptor.Field(e => e.FirstName).Type<NonNullType<StringType>>();
        descriptor.Field(e => e.SecondName).Type<NonNullType<StringType>>();
        descriptor.Field(e => e.Position).Type<NonNullType<StringType>>();
    }
}
