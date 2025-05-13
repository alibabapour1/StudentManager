using StudentManagement.Core.Abstractions.Mediator;
using System;

namespace StudentManagement.Core.Students.Commands
{
    public record DeleteStudentCommand(int Id) : ICommand<string>;
}
