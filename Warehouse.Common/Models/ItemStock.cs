using Warehouse.Common.Models.Base;

namespace Warehouse.Common.Models
{
    public class ItemStock : BaseModel
    {
        public required int Amount { get; set; } = 0;
    }
}