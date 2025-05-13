using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Core.Students.Queries.GetById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students.Queries.GetAllStudents
{
    public  record GetAllStudentsQuery : IQuery<List<StudentDto>>;
    
}
