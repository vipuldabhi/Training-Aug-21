using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<Student> UpdateStudent(Student student,int id);
        Task<Student> AddStudent(Student student);
        Task<Student> DeleteStudent(int id);
    }
}
