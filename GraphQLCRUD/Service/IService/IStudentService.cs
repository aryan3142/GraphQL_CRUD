using GraphQLCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCRUD.Service.IService
{
    public interface IStudentService
    {
        IQueryable<Student> GetALLStudent();
        Student Create(CreateStudentInput inputStudent);
        Student Delete(DeleteStudentInput inputStudent);
    }
}
