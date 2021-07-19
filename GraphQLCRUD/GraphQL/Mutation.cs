using GraphQLCRUD.Models;
using GraphQLCRUD.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCRUD.GraphQL
{
    public class Mutation
    {
        private readonly IStudentService _studentService;

        public Mutation(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public Student CreateStudent(CreateStudentInput studentInput)
        {
            return _studentService.Create(studentInput);
        }
        public Student DeleteStudent(DeleteStudentInput studentInput)
        {
            return _studentService.Delete(studentInput);
        }
    }
}
