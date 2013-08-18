using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Schools.Data;

namespace Schools.Repositories
{
    public class DBStudentsRepository : IRepository<Student>
    {
        private DbContext dbContext;
        private DbSet<Student> entitySet;

        public DBStudentsRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Student>();
        }        

        public Student Add(Student item)
        {
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public Student Update(int id, Student item)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Delete(Student item)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Student> All()
        {
            return this.entitySet;
        }

        public IQueryable<Student> Find(Expression<Func<Student, int, bool>> predicate)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
