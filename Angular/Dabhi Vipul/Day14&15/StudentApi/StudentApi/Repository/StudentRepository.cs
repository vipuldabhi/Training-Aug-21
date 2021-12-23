using Microsoft.EntityFrameworkCore;
using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDatabaseContext _studentDatabaseContext;

        public StudentRepository(StudentDatabaseContext studentDatabaseContext)
        {
            _studentDatabaseContext = studentDatabaseContext;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _studentDatabaseContext.Students.ToListAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _studentDatabaseContext.Students.FirstOrDefaultAsync(a => a.StudentId == id);
        }

        public async Task<Student> UpdateStudent(Student student,int id)
        {
            var Result = await _studentDatabaseContext.Students.FirstOrDefaultAsync(a => a.StudentId == id);
            if(Result != null)
            {
				Result.StudentId = student.StudentId;
				Result.Firstname = student.Firstname;
				Result.Middlename = student.Middlename;
				Result.Lastname = student.Lastname;
				Result.Dateofbirth = student.Dateofbirth;
				Result.Placeofbirth = student.Placeofbirth;
				Result.Firstlanguage = student.Firstlanguage;
				Result.City = student.City;
				Result.State = student.State;
				Result.Country = student.Country;
				Result.Pin = student.Pin;
				Result.Fatherfirstname = student.Fatherfirstname;
				Result.Fathermiddlename = student.Fathermiddlename;
				Result.Fatherlastname = student.Fatherlastname;
				Result.Fatheremail = student.Fatheremail;
				Result.Fatherqualification = student.Fatherqualification;
				Result.Fatherprofession = student.Fatherprofession;
				Result.Fatherdesignation = student.Fatherdesignation;
				Result.Fatherphone = student.Fatherphone;
				Result.Motherfirstname = student.Motherfirstname;
				Result.Mothermiddlename = student.Mothermiddlename;
				Result.Motherlastname = student.Motherlastname;
				Result.Motheremail = student.Motheremail;
				Result.Motherqualification = student.Motherqualification;
				Result.Motherprofession = student.Motherqualification;
				Result.Motherdesignation = student.Motherdesignation;
				Result.Motherphone = student.Motherphone;
				Result.Refdetails = student.Refdetails;
				Result.Refthrough = student.Refthrough;
				Result.Refaddress = student.Refaddress;
				Result.Emergencies = student.Emergencies;
				await _studentDatabaseContext.SaveChangesAsync();
				return Result;
            }
			return null;
        }
        public async Task<Student> AddStudent(Student student)
        {
			var Result = _studentDatabaseContext.Students.Add(student);
			await _studentDatabaseContext.SaveChangesAsync();
			return Result.Entity;
        }
        public async Task<Student> DeleteStudent(int id)
        {
			var Result = _studentDatabaseContext.Students.Where(a => a.StudentId == id).FirstOrDefault();
			if(Result != null)
            {
				_studentDatabaseContext.Students.Remove(Result);
				await _studentDatabaseContext.SaveChangesAsync();
				return Result;
            }
			return null;
        }

    }
}
