using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications.Courses
{
    public class CourseWhitCategoriesAndIndexeSpecification: BaseSpecification<Course>
    {
        public CourseWhitCategoriesAndIndexeSpecification()
        {
            AddInclude(c => c.Categories);
            AddInclude(c => c.Index);
        }
        public CourseWhitCategoriesAndIndexeSpecification(int id): base(x => x.Id == id)
        {
            AddInclude(c => c.Categories);
            AddInclude(c => c.Index);
        }

    }
}
