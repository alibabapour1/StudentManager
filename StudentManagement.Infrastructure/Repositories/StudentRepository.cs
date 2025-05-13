using StudentManagement.Core.Students;
using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        public Task Update(string firstName, string lastName, double average, Fields field)
        {
            throw new NotImplementedException();
        }

        Task IStudentRepository.Create(Student student)
        {
            throw new NotImplementedException();
        }

        Task IStudentRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Student>> IStudentRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Student?> IStudentRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
