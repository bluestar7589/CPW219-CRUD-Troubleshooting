using Microsoft.EntityFrameworkCore;

namespace CPW219_CRUD_Troubleshooting.Models
{
    public static class StudentDb
    {
        public static async Task<Student> Add(Student p, SchoolContext db)
        {
            //Add student to context
            db.Students.Add(p);
            await db.SaveChangesAsync();
            return p;
        }

        public static async Task<List<Student>> GetStudents(SchoolContext context)
        {
            return await (from s in context.Students
                    select s).ToListAsync();
        }

        public static Student GetStudent(SchoolContext context, int id)
        {
            Student p2 = context
                            .Students
                            .Where(s => s.StudentId == id)
                            .Single();
            return p2;
        }

        public static async Task Delete(SchoolContext context, Student p)
        {
            //Mark the object as deleted
            context.Students.Remove(p);
            //Send delete query to database
            await context.SaveChangesAsync();
        }

        public static async Task Update(SchoolContext context, Student p)
        {
            // Mark the object to update
            context.Students.Update(p);

            //Send upadte query to database
            await context.SaveChangesAsync();
        }
    }
}
