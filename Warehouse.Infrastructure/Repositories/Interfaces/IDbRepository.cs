﻿using FluentResults;

namespace Warehouse.Infrastructure.Repositories.Interfaces;

public interface IDbRepository<T>
{
    /// <summary>
    /// Retrieves all entities of the provided type from the database
    /// </summary>
    /// <returns>A collection of entities</returns>
    Task<Result<IEnumerable<T>>> GetAllAsync();

    /// <summary>
    /// Retrieves the first entity with the provided id.
    /// </summary>
    /// <param name="id">The id of the type</param>
    /// <returns>The entity if found</returns>
    Task<Result<T>> GetByIdAsync(string id);

    /// <summary>
    /// Creates a new entity of the provided type and saves it
    /// </summary>
    /// <param name="entity">The entity that is to be created</param>
    /// <returns>A result indicating success or failure</returns>
    Task<Result<T>> CreateAsync(T entity);

    /// <summary>
    /// Updates an already existing entity with provided one
    /// </summary>
    /// <param name="entity">The entity which should be updated</param>
    /// <returns>A result indicating success or failure</returns>
    Task<Result> UpdateAsync(T entity);

    /// <summary>
    /// Removes the entity matching the id provided
    /// </summary>
    /// <param name="id">The id of the entity to be deleted</param>
    /// <returns>A result indicating success or failure</returns>
    Task<Result> DeleteAsync(string id);
}