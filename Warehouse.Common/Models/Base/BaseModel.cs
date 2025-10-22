using RepoDb.Attributes;

namespace Warehouse.Common.Models.Base
{
    public abstract class BaseModel
    {
        [Primary]
        public required string Id { get; set; }
    }
}