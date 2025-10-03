namespace ECom.Application.Repositories
{
    public interface IVersionRepository
    {
        Task<Version> GetByIdAsync(object id);
        Task<IEnumerable<Version>> ListAsync();
        Task AddAsync(Version entity);
        Task UpdateAsync(Version entity);
        Task DeleteAsync(object id);
    }
}