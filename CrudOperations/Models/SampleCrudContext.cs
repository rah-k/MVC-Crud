using Microsoft.EntityFrameworkCore;

namespace CurdOperation.Models
{
    public class SampleCrudContext:DbContext
    {
        public SampleCrudContext(DbContextOptions<SampleCrudContext>options):base(options)
        {

        }
        public  DbSet<StudentModel> StudentData { get; set; }
    }
}
