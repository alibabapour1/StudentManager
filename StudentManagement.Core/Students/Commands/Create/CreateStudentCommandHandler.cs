using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Domain.Abstractions;
using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students.Commands.Create
{
    public class CreateStudentCommandHandler : ICommandHandler<CreateStudentCommand, string>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Result<string>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Result.Failure<string>(Error.NullValue);

            if (request.Average < 0 || request.Average > 20)
            {
                return Result.Failure<string>(StudentErrors.WrongAverage);
            }

            if (!Enum.IsDefined(typeof(Fields), request.Field))
            {
                return Result.Failure<string>(StudentErrors.WrongFields);
            }

            var student = Student.Create(request.FirstName, request.LastName, request.Average, request.Field);
            await _studentRepository.Create(student);
            return "Student Created Sucessfully";



        }
    }
}
