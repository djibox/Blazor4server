using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor4Server.Data;
using Blazor4Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor4Server.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext DbContext;

        public StudentService(ApplicationDbContext context)
        {
            DbContext = context;
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            var result = DbContext.Students;
            return await Task.FromResult(result.ToList());
        }

        public async Task<Student> GetStudentByIdAsync(string id)
        {
            return await DbContext.Students.FindAsync(id);
        }

        public async Task<Student> InsertStudentAsync(Student student)
        {
            DbContext.Students.Add(student);
            await DbContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student> UpdateStudentAsync(string id, Student student)
        {
            var s = await DbContext.Students.FindAsync(id);
            if(s!=null)
            {
                s.Firstname = student.Firstname;
                s.Lastname = student.Lastname;
                s.School = student.School;
                DbContext.Students.Update(s);
                await DbContext.SaveChangesAsync();
            }

            return s;
        }
        public async Task<Student> DeleteAsync(string id)
        {
            var s = await DbContext.Students.FindAsync(id);
            if (s != null)
            {
                DbContext.Students.Remove(s);
                await DbContext.SaveChangesAsync();
            }
            return s;
        }
    }
}
