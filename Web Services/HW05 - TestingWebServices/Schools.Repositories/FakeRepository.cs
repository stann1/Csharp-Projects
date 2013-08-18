using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Schools.Data;

namespace Schools.Repositories
{
    public class FakeRepository : IRepository<Student>
    {
        private IList<Student> entitySey;

        public FakeRepository()
        {
            this.entitySey = new List<Student>();
        }

        public Student Add(Student item)
        {
            this.entitySey.Add(item);
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
            return this.entitySey[id];
        }

        public IQueryable<Student> All()
        {
            return this.entitySey.AsQueryable();
        }

        public IQueryable<Student> Find(Expression<Func<Student, int, bool>> predicate)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
