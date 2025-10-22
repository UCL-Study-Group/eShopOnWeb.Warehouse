using FluentResults;
using Warehouse.Common.Models.Base;
using Warehouse.Infrastructure.Repositories.Interfaces;

namespace Warehouse.Infrastructure.Repositories;

public class PostgresRepository<T> : IDbRepository<T> where T : BaseModel
{
    public async Task<Result<T>> CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<IEnumerable<T>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Result<T>> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
