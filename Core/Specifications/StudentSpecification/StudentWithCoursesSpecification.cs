using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications.StudentSpecification
{
    public class StudentWithCoursesSpecification: BaseSpecification<Student>
    {
        public StudentWithCoursesSpecification()
        {
            AddInclude(s => s.Courses);

        }

        public StudentWithCoursesSpecification(int id) : base(x => x.Id == id)
        {

            AddInclude(s => s.Courses);
        }
    }
}
