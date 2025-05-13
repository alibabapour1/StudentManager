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
        Task<Student> GetById(int id);
        Task<List<Student>> GetAll(); 
        Task Create(Student student);
        Task Update(string firstName,string lastName , double average,Fields field );
        Task Delete(int id);

    }
}
