using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students.Commands.Create
{
    public record CreateStrudentCommand(string FirstName, string LastName, double Average, Fields Field) : ICommand<string>;
}
