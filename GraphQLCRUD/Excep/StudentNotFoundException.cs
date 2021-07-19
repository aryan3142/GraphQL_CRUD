using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCRUD.Excep
{
    public class StudentNotFoundException : Exception
    {
        public int StudentId { get; internal set; }
    }
}
