using ECom.Application.Services.Interfaces;
using ECom.Infrastructure.Repositories;

namespace ECom.Application.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly GenericRepository<T> _repository;
        public GenericService(GenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T> GetByIdAsync(object id) => await _repository.GetByIdAsync(id);
        public virtual async Task<IEnumerable<T>> ListAsync() => await _repository.ListAsync();
        public virtual async Task AddAsync(T entity) => await _repository.AddAsync(entity);
        public virtual async Task UpdateAsync(T entity) => await _repository.UpdateAsync(entity);
        public virtual async Task DeleteAsync(object id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null) await _repository.DeleteAsync(entity);
        }
    }
}