using Microsoft.EntityFrameworkCore;
using StudentCRUD.Models;

namespace StudentCRUD.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentModel>students { get; set; }
    }
}
