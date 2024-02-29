namespace DataAccessLayer;
public interface IEntityRepository<T> where T : class
{
    public Task<IEnumerable<T>> GetAll();
    public Task<T> GetById(Guid id);

    public Task<T> Insert(T entity);
    public Task<T> Update(T entity);

    public void Delete(Guid id);
}
