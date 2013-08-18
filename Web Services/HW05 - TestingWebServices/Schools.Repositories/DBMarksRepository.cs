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
    public class DBMarksRepository : IRepository<Mark>
    {
        private DbContext dbContext;
        private DbSet<Mark> entitySet;

        public DBMarksRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.entitySet = this.dbContext.Set<Mark>();
        }

        public Mark Add(Mark item)
        {
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();
            return item;
        }

        public Mark Update(int id, Mark item)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void Delete(Mark item)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public Mark Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Mark> All()
        {
            return this.entitySet;
        }

        public IQueryable<Mark> Find(Expression<Func<Mark, int, bool>> predicate)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
