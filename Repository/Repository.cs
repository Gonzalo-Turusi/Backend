using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private ExampleDbContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(ExampleDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity? Get(int id) => _dbSet.Find(id);

        public TEntity Add(TEntity data)
        {
            var entityEntry = _dbSet.Add(data);
            return entityEntry.Entity;
        }

        public TEntity? Update(int id, TEntity data)
        {
            var existingEntity = _dbSet.Find(id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).CurrentValues.SetValues(data);
                _context.Entry(existingEntity).State = EntityState.Modified;
            }
            return existingEntity;
        }

        public TEntity? Delete(int id)
        {
            var dataToDelete = _dbSet.Find(id);
            if (dataToDelete != null)
                _dbSet.Remove(dataToDelete);
            return dataToDelete;
        }

        public void Save() => _context.SaveChanges();
    }
}
