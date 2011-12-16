namespace Restauracja.ServerDTO
{
    public class TableDTO
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public static TableDTO ToDto(BusinessLayer.Table table)
        {
            return new TableDTO
                       {
                           ID = table.id, 
                           Name = table.name, 
                           Number = table.number
                       };
        }
    }
}
