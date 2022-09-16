using BussinesLogic.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.Students;

namespace UniversityApiBE.Services.Students
{
    public class StudentsServices : IStudentsService
    {
        private readonly UniversityDBContext _context;

        public StudentsServices(UniversityDBContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> FilterStudentsByCoursesAsync(int courseId)
        {
            var courseExist = await _context.Courses.AnyAsync(c => c.Id == courseId);

            if (!courseExist)
                return null;

            return await _context.Students
                .Include(s => s.Courses)
                .Where(s => s.Courses.Any(c => c.Id == courseId))
                .ToListAsync();
        }

        public async Task<List<Student>> FilterStudentsWithOutCoursesAsync()
        {
            return await _context.Students
                         .Where(s => s.Courses.Count == 0)
                         .Include(s => s.Courses)
                         .ToListAsync();

        }

        public async Task<int> UpdateStudentAsync(int id, StudentUpdateDto dto)
        {

            var studentDb = await _context.Students
                            .Include(s => s.Courses)
                            .FirstOrDefaultAsync(c => c.Id == id);

            if (studentDb == null)
            {
                throw new ArgumentNullException("entity");
            }

            // Actualizamos las props con las que llegan en la request no las relaciones
            _context.Entry(studentDb).CurrentValues.SetValues(dto);

            if (dto.CoursesId != null)
            {
                // Eliminamos las relaciones actuales del registro de la bdd
                var coursesToRemove = studentDb.Courses.ToList();
                foreach (var oldCourse in coursesToRemove)
                    studentDb.Courses.Remove(oldCourse);


                // Añadimos todas las relaciones que llegan des de el cliente
                var coursesToAdd = await _context.Courses
                    .Where(c => dto.CoursesId.Contains(c.Id))
                    .ToListAsync();
                foreach (var courseToAdd in coursesToAdd)
                    studentDb.Courses.Add(courseToAdd);

            }
            else
            {
                var coursesToRemove = studentDb.Courses.ToList();
                foreach (var oldCourse in coursesToRemove)
                    studentDb.Courses.Remove(oldCourse);
            }

            return await _context.SaveChangesAsync();
        }


        //public IEnumerable<Course> GetStudentCourses(Student student, IEnumerable<Course> coursesList)
        //{
        //    var studentCoursesList = from studentCourse in student.Courses
        //                             from course in coursesList
        //                             where course.Id == studentCourse.Id
        //                             select course;
        //    return studentCoursesList;
        //}

        //public IEnumerable<Student> GetStudentsWhitCourses(IEnumerable<Student> studentList)
        //{
        //    var studentsWhitCourses = from student in studentList
        //                              where student.Courses.Count > 0
        //                              select student;
        //    return studentsWhitCourses;
        //}

        //public IEnumerable<Student> GetStudentsWhitNotCourses(IEnumerable<Student> studentList)
        //{
        //    var studentsWhitCourses = from student in studentList
        //                              where student.Courses.Count == 0
        //                              select student;
        //    return studentsWhitCourses;
        //}


    }


}
