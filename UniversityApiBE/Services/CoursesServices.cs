
using BussinesLogic.Data;
using UniversityApiBE.Services;

namespace universityapibe.services
{
    public class CoursesServices : ICoursesServices
    {
        private readonly UniversityDBContext _context;

        public CoursesServices(UniversityDBContext context)
        {
            _context = context;
        }

        //public ienumerable<course> getcoursesbycategory(ienumerable<course> courseslist, category category)
        //{
        //    var coursesbycategory = from courses in courseslist
        //                            from cat in courses.categories
        //                            where (cat.id == category.id)
        //                            select courses;

        //    return coursesbycategory;
        //}

        //public index getcourseindex(course course, list<index> indexlist)
        //{
        //    var indexmatch = from index in indexlist
        //                     where index.id == course.idindex
        //                     select index;

        //    return (index)indexmatch;
        //}

        //public ienumerable<course> getcourseswhitnotindexes(ienumerable<course> courseslist)
        //{
        //    var coursesmatch = courseslist.where(course => course.idindex == null);
        //    return coursesmatch;
        //}

        //public ienumerable<student> getcoursestudents(course course, ienumerable<student> studentslist)
        //{
        //    var studentsmatch = from student in studentslist
        //                        from cstudent in course.students
        //                        where cstudent.id == student.id
        //                        select student;

        //    return studentsmatch;

        //}

        /*el cliente envía un nuevo objeto curso con una propiedad categories con ids de nuevas categorias*/
        //public async task<int> updatecourse(courseupdatedto courseupdatedto)
        //{
        //    // fetch al curso existente y sus categorias relacionadas
        //    var course = await _context.courses
        //        .include(c => c.categories)
        //        .firstordefaultasync(c => c.id == courseupdatedto.id);

        //    /* borramos las categorias que tiene el curso actualmente en la bdd */
        //    course.categories.clear();

        //    /*añadimos las nuevas categorias de la lista que esta mandando el cliente
        //     pero para identificarlos hemos de recibir la lista de categorias disponibles en la bdd*/
        //    var availablecategories = await _context.categories.tolistasync();
        //    foreach (var id in courseupdatedto.categories)
        //    {
        //        course.categories.add(availablecategories.first(coursecat => coursecat.id == id));
        //    }

        //    // modificamos las demas propiedades
        //    course.name = courseupdatedto.name;
        //    course.shortdescription = courseupdatedto.shortdescription;
        //    course.longdescription = courseupdatedto.longdescription;
        //    course.level = courseupdatedto.level;
        //    course.index.id = courseupdatedto.index;
        //    //course.index = courseupdatedto.index;

        //    return await _context.savechangesasync();
        //}


    }
}
