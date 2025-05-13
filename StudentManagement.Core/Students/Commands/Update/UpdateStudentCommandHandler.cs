using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Domain.Abstractions;
using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students.Commands
{
    public class UpdateStudentCommandHandler : ICommandHandler<UpdateStudentCommand, string>
    {
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Result<string>> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
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

            var existingStudent = await _studentRepository.GetById(request.Id);
            if (existingStudent == null) 
            {
                return Result.Failure<string>(StudentErrors.NotFound);

            }
            existingStudent.FirstName = request.FirstName;
            existingStudent.LastName = request.LastName;
            existingStudent.Average  = request.Average;
            existingStudent.Field = request.Field;

            
            await _studentRepository.Update(existingStudent);
            return "Student Updated Sucessfully";
            


        }
    }
}
