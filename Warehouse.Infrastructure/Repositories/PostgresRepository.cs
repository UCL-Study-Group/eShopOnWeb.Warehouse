using FluentResults;
using Microsoft.Data.SqlClient;
using Npgsql;
using Microsoft.Extensions.Options;
using RepoDb;
using System.Threading;
using Warehouse.Common.Models.Base;
using Warehouse.Infrastructure.Models;
using Warehouse.Infrastructure.Repositories.Interfaces;

namespace Warehouse.Infrastructure.Repositories;

public class PostgresRepository<T> : IDbRepository<T> where T : BaseModel
{
    private readonly string _connectionString;

    public PostgresRepository(IOptions<DbCredentials> options)
    {
        _connectionString = options.Value.ConnectionString
            ?? throw new ArgumentNullException(nameof(options));
    }

    public async Task<Result<T>> CreateAsync(T entity)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(entity);
            await using var connection = new NpgsqlConnection(_connectionString);
            await connection.InsertAsync(entity);

            return Result.Ok(entity);
        }
        catch (Exception)
        {
            return Result.Fail("Couldn't create provided item");
        }
    }

    public async Task<Result> DeleteAsync(string id)
    {
        try
        {
            await using var connection = new NpgsqlConnection(_connectionString);
            await connection.DeleteAsync(id);

            return Result.Ok();
        }
        catch (Exception)
        {
            return Result.Fail("Failed to delete provided id");
        }
    }

    public async Task<Result<IEnumerable<T>>> GetAllAsync()
    {
        try
        {
            await using var connection = new NpgsqlConnection(_connectionString);
            var result = await connection.QueryAllAsync<T>();

            return Result.Ok(result);
        }
        catch (Exception)
        {
            return Result.Fail("Could not retrieve collection");
        }
    }

    public async Task<Result<T>> GetByIdAsync(string id)
    {
        try
        {
            await using var connection = new NpgsqlConnection(_connectionString);
            var result = await connection.QueryAsync<T>(id);

            return Result.Ok(result.FirstOrDefault());
        }
        catch (Exception)
        {
            return Result.Fail("Couldn't find an item with the specified id");
        }
    }

    public async Task<Result> UpdateAsync(T entity)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(entity);
            await using var connection = new NpgsqlConnection(_connectionString);
            await connection.UpdateAsync(entity);

            return Result.Ok();
        }
        catch (Exception)
        {
            return Result.Fail("Couldn't update provided item");
        }
    }
}