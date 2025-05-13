using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Core.Students.Queries.GetById;
using System;

namespace StudentManagement.Core.Students.Queries
{
    public record GetStudentByIdQuery(int Id) : IQuery<StudentDto>;
}

