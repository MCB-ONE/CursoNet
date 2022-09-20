using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications.Courses
{
    public class CourseFullSpecification: BaseSpecification<Course>
    {
        public CourseFullSpecification()
        {
            AddInclude(c => c.Categories);
            AddInclude(c => c.Index);
            AddInclude(c => c.Students);
        }
        public CourseFullSpecification(int id): base(x => x.Id == id)
        {
            AddInclude(c => c.Categories);
            AddInclude(c => c.Index);
            AddInclude(c => c.Students);
        }

    }
}
