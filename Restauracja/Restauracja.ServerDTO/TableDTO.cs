using Restauracja.BusinessLayer;

namespace Restauracja.ServerDTO
{
    public class TableDTO
    {
        public int ID { get; set; }
        public short Number { get; set; }
        public string Name { get; set; }

        public static TableDTO ToDto(Table table)
        {
            return new TableDTO
                       {
                           ID = table.id, 
                           Name = table.name, 
                           Number = table.number
                       };
        }

        public static Table FromDto(TableDTO tableDTO)
        {
            return new Table
                       {
                           id = tableDTO.ID,
                           name = tableDTO.Name,
                           number = tableDTO.Number
                       };
        }
    }
}
