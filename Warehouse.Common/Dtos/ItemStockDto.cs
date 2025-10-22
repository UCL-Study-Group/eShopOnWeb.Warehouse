using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Common.Dtos
{
    public class ItemStockDto
    {
        public required string Id { get; set; }
        public int? Amount { get; set; }
    }
}
