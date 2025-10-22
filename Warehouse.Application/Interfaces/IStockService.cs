using Warehouse.Common.Dtos;
using Warehouse.Common.Models;
using FluentResults;

namespace Warehouse.Application.Interfaces;

public interface IStockService
{
    Task<ItemStock?> CreateAsync(ItemStockDto dto);
    Task<ItemStockDto?> GetAsync(string id);
    Task<IEnumerable<ItemStockDto>?> GetAllAsync();
    Task<Result> UpdateAsync(ItemStockDto dto);
    Task<Result> DeleteAsync(string id);
}
