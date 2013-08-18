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
    public class DBSchoolsRepository : IRepository<School>
    {
        private DbContext dbContext;
        private DbSet<School> entitySet;

        public DBSchoolsRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<School>();
        }
       
        public School Add(School item)
        {
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public School Update(int id, School item)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Delete(School item)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public School Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<School> All()
        {
            return this.entitySet;
        }

        public IQueryable<School> Find(Expression<Func<School, int, bool>> predicate)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
