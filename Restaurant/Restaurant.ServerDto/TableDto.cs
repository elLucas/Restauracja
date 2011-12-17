namespace Restaurant.DTO
{
    public class TableDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Number { get; set; }

    #if SILVERLIGHT
    #else
        public static TableDto ToDto(BusinessLayer.Table table)
        {
            return new TableDto
                       {
                           Id = table.Id,
                           Name = table.Name,
                           Number = table.Number
                       };
        }

        public static BusinessLayer.Table FromDto(TableDto tableDto)
        {
            return new BusinessLayer.Table
                       {
                           Id = tableDto.Id,
                           Name = tableDto.Name,
                           Number = tableDto.Number
                       };
        }
    #endif
    }
}
