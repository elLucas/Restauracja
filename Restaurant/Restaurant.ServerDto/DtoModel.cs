using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.DTO
{
    public class DtoModel
    {
        public Dictionary<int, TableDto> Tables;
        public Dictionary<int, OrderDto> Orders;

        public void MapEntities()
        {
            if (Tables != null)
                foreach (var table in Tables.Values)
                    table.Model = this;
            if (Orders != null)
                foreach (var orderDto in Orders.Values)
                    orderDto.Model = this;
        }
    }
}
