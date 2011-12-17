namespace Restaurant.DTO
{
    public class WorkerDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short? Number { get; set; }
        public short Pin { get; set; }

#if SILVERLIGHT
#else
        public static WorkerDto ToDto(BusinessLayer.Worker worker)
        {
            return new WorkerDto()
                       {
                           Id = worker.Id,
                           Name = worker.Name,
                           Surname = worker.Surname,
                           Number = worker.Number,
                           Pin = worker.Pin
                       };
        }

        public static BusinessLayer.Worker FromDto(WorkerDto worker)
        {
            return new BusinessLayer.Worker()
                       {
                           Id = worker.Id,
                           Name = worker.Name,
                           Surname = worker.Surname,
                           Number = worker.Number,
                           Pin = worker.Pin
                       };
        }
#endif
    }
}
