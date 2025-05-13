using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core.Students
{
    public interface IStudentRepository
    {
        Task<Student?> GetById(int id);
        Task<IEnumerable<Student>> GetAll(); 
        Task Create(Student student);
        Task Update(Student student );
        Task Delete(int id);

    }
}
