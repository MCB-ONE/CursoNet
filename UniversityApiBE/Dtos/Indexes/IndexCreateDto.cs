using Core.Entities;

namespace UniversityApiBE.Dtos.Indexes
{
    public class IndexCreateDto: BaseEntity
    {
        public int CourseId { get; set; }
        public string List { get; set; }

    }
}
