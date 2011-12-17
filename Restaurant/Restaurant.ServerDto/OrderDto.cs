namespace Restaurant.DTO
{
    public class OrderDto : BaseDto
    {
        public int Id { get; set; }
        public int IdWaiter { get; set; }
        public int IdTable { get; set; }
        public string Comment { get; set; }
        public bool Closed { get; set; }

#if SILVERLIGHT
#else
        public static OrderDto ToDo(BusinessLayer.Order order)
        {
            return new OrderDto()
                       {
                           Id = order.Id,
                           IdWaiter = order.Id_waiter,
                           IdTable = order.Id_table,
                           Comment = order.Comment,
                           Closed = order.Closed
                       };
        }

        public static BusinessLayer.Order FromDto(OrderDto orderDto)
        {
            return new BusinessLayer.Order()
                       {
                           Id = orderDto.Id,
                           Id_waiter = orderDto.IdWaiter,
                           Id_table = orderDto.IdTable,
                           Comment = orderDto.Comment,
                           Closed = orderDto.Closed
                       };
        }
#endif
    }
}
