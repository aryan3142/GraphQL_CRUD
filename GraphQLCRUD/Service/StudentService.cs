using GraphQLCRUD.Excep;
using GraphQLCRUD.Models;
using GraphQLCRUD.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCRUD.Service
{
    public class StudentService : IStudentService
    {
        private IList<Student> _students;
        public StudentService()
        {
            _students = new List<Student>()
            {
                new Student(){Name = "Aryan", StudentId=1,GroupId=2},
                new Student(){Name = "Anish", StudentId=2,GroupId=1},
                new Student(){Name = "Avinash", StudentId=3,GroupId=2},
                new Student(){Name = "Anas", StudentId=4,GroupId=3}
            };
        }
        public Student Create(CreateStudentInput inputStudent)
        {
            var student = new Student()
            {
                StudentId = _students.Max(x => x.StudentId) + 1,
                Name = inputStudent.Name,
                GroupId = inputStudent.GroupId
            };
            _students.Add(student);
            return student;
        }

        public Student Delete(DeleteStudentInput inputStudent)
        {
            var student = _students.FirstOrDefault(x => x.StudentId == inputStudent.StudentId);
            if (student == null) throw new StudentNotFoundException { StudentId = inputStudent.StudentId };
            _students.Remove(student);
            return student;
        }

        public IQueryable<Student> GetALLStudent()
        {
            return _students.AsQueryable();
        }
    }
}
