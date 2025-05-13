using StudentManagement.Core.Abstractions.Mediator;
using System;

namespace StudentManagement.Core.Students.Queries
{
    public record GetStudentByIdQuery(int Id) : IQuery<StudentDto>;
}

