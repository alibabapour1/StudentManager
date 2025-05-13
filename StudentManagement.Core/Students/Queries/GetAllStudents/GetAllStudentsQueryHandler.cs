using StudentManagement.Core.Abstractions.Mediator;
using StudentManagement.Core.Students.Queries.GetAllStudents;
using StudentManagement.Domain.Abstractions;
using StudentManagement.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students.Queries
{
    public class GetAllStudentsQueryHandler : IQueryHandler<GetAllStudentsQuery, List<StudentDto>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetAllStudentsQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Result<List<StudentDto>>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAll();

            if (students == null || !students.Any())
                return Result.Failure<List<StudentDto>>(StudentErrors.NotFound);

            var dtoList = students.Select(student => new StudentDto
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Average = student.Average,
                Field = student.Field.ToString()
            }).ToList();

            return Result.Success(dtoList);
        }
    }
}
