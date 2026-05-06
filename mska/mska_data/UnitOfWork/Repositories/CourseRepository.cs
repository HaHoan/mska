using Microsoft.EntityFrameworkCore;
using mska_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mska_data.Repositories
{
    public class CourseRepository: BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(MskacenterDbContext context) : base(context)
        {
        }

       
    }
}
