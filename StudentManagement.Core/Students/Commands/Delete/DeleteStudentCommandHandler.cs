using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Domain.Abstractions;
using StudentManagement.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students.Commands
{
    public class DeleteStudentCommandHandler : ICommandHandler<DeleteStudentCommand, string>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Result<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Result.Failure<string>(Error.NullValue);

            var existingStudent = await _studentRepository.GetById(request.Id);

            if (existingStudent == null)
                return Result.Failure<string>(StudentErrors.NotFound);

            await _studentRepository.Delete(existingStudent.Id);

            return Result.Success("Student deleted successfully");
        }
    }
}
