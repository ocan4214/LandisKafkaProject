using Microsoft.EntityFrameworkCore;
using System;

/// <summary>
///	 Base Repo Provider Interface
/// </summary>
public interface IBaseRepository<T> where T : class
{
    Task<T> GetByIDAsync(string id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(string id);

    T GetByID(string id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(string id);
}
