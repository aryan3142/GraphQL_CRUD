using GraphQLCRUD.Models;
using GraphQLCRUD.Service.IService;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCRUD.GraphQL
{
    public class StudentType : ObjectType<Student>
    {
        protected override void Configure(IObjectTypeDescriptor<Student> descriptor)
        {
            descriptor.Field(x => x.StudentId).Type<IdType>();
            descriptor.Field(x => x.Name).Type<StringType>();
            descriptor.Field<GroupResolver>(x => x.GetGroup(default, default));

        }
    }
    public class GroupResolver
    {
        private readonly IGroupService _groupService;

        public GroupResolver(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public Group GetGroup(Student student, IResolverContext ctx)
        {
            return _groupService.GetAllGroup().Where(x => x.GroupId == student.GroupId).FirstOrDefault();
        }
    }
}
