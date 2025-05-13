using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Core.Students.Queries.GetById;
using StudentManagement.Domain.Abstractions;
using StudentManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students.Queries
{
    public class GetStudentByIdQueryHandler : IQueryHandler<GetStudentByIdQuery, StudentDto>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Result<StudentDto>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            if (request == null)
                return Result.Failure<StudentDto>(Error.NullValue);

            var student = await _studentRepository.GetById(request.Id);

            if (student == null)
                return Result.Failure<StudentDto>(StudentErrors.NotFound);

            var dto = new StudentDto
            {
                Id = request.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Average = student.Average,
                Field = student.Field.ToString()
            };

            return Result.Success(dto);
        }
    }
}
