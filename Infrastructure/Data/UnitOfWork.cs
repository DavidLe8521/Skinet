using System.Collections;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _context;
        private Hashtable _repositories;
        public UnitOfWork(StoreContext context)
        {
            _context = context;
        }

        public async Task<int> Complete()
        {
            // throw new NotImplementedException();
            return await _context.SaveChangesAsync();
            
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
            _context.Dispose();
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            // throw new NotImplementedException();
            if (_repositories == null) _repositories = new Hashtable();
            var type = typeof(TEntity).Name;
            if(!_repositories.ContainsKey(type)){
                var repositoryType = typeof(GenericRepository<>);
                var repositoyInstance = Activator.CreateInstance(repositoryType.MakeGenericType
                    (typeof(TEntity)), _context);
                _repositories.Add(type, repositoyInstance);
            }
            return (IGenericRepository<TEntity>) _repositories[type];
        }
    }
}