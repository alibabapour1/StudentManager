using Microsoft.EntityFrameworkCore;
using StudentManagement.Core.Students;
using StudentManagement.Domain.Entities;
using StudentManagement.Infrastructure.Context;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Create(Student student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Student>> GetAll()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student?> GetById(int id)
    {
        return await _context.Students.FindAsync(id);
    }

    public async Task Update(Student updatedStudent)
    {
        _context.Students.Update(updatedStudent);
        await _context.SaveChangesAsync();
    }
}
