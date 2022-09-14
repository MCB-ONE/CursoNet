using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications.UserSpecifications
{
    public class UserWithStudentSpecification : BaseSpecification<User>
    {
        public UserWithStudentSpecification()
        {
            AddInclude(user => user.Student);
            AddInclude(user => user.Student.Courses);
        }

        public UserWithStudentSpecification(int id) : base(x => x.Id == id) 
        {
            AddInclude(user => user.Student);
            AddInclude(user => user.Student.Courses);
        }
    }
}
