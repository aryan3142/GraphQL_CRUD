using GraphQLCRUD.Models;
using GraphQLCRUD.Service.IService;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCRUD.GraphQL
{
    public class Query
    {
        private readonly IStudentService _studentService;
        private readonly IGroupService _groupService;

        public Query(IStudentService studentService, IGroupService groupService)
        {
            _studentService = studentService;
            _groupService = groupService;
        }

        [UsePaging(SchemaType = typeof(GroupType))]
        [UseFiltering]
        public IQueryable<Group> Groups => _groupService.GetAllGroup();
        [UsePaging(SchemaType = typeof(StudentType))]
        [UseFiltering]
        public IQueryable<Student> Students => _studentService.GetALLStudent();
    }
}
