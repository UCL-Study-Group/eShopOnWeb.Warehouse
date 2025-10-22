using FluentResults;
using Warehouse.Application.Interfaces;
using Warehouse.Common.Dtos;
using Warehouse.Common.Models;
using Warehouse.Infrastructure.Repositories.Interfaces;

namespace Warehouse.Application.Services;

public class StockService : IStockService
{
    private readonly IDbRepository<ItemStock> _itemDbRepository;

    public StockService(IDbRepository<ItemStock> itemDbRepository)
    {
        _itemDbRepository = itemDbRepository;
    }

    public Task<ItemStock?> CreateAsync(ItemStockDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ItemStockDto>?> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ItemStockDto?> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Result> UpdateAsync(ItemStockDto dto)
    {
        throw new NotImplementedException();
    }
}
