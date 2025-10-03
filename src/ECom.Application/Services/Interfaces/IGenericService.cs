namespace ECom.Application.Services.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<T> GetByIdAsync(object id);
        Task<IEnumerable<T>> ListAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object id);
    }
}