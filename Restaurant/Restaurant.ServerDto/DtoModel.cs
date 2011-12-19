using System.Collections.Generic;

namespace Restaurant.DTO
{
    public class DtoModel
    {
        public Dictionary<int, TableDto> Tables;
        public Dictionary<int, OrderDto> Orders;
        public Dictionary<int, WorkerDto> Workers;
        public Dictionary<int, ProductDto> Products;
        public Dictionary<int, ReceiptDto> Receipts;

        public void MapEntities()
        {
            if (Tables != null)
                foreach (var table in Tables.Values)
                    table.Model = this;

            if (Orders != null)
                foreach (var orderDto in Orders.Values)
                    orderDto.Model = this;

            if (Workers != null)
                foreach (var workerDto in Workers.Values)
                    workerDto.Model = this;

            if (Products != null)
                foreach (var productDto in Products.Values)
                    productDto.Model = this;

            if (Receipts != null)
                foreach (var receiptDto in Receipts.Values)
                    receiptDto.Model = this;
        }
    }
}
