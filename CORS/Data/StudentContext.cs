using Microsoft.EntityFrameworkCore;

namespace CORS.Data
{
    public class StudentContext : DbContext // direk sınıf üzerinde gelerek otionsconstractırı oluşturabilirsin veya ctor da yazaark mauel olarak ta yazabilirsin
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Student>().HasData(new Student[] // buyle yaparak dataları burdan db ye ekliyorsun miggration atarark
            {
                new Student() {Name="Yavuz",Age=22,Surname="Kahraman",Id=1},
                new Student() {Name="Mehmet",Age=25,Surname="Kahraman",Id= 2},
            });
            base.OnModelCreating(modelBuilder);
        }

    }
}
