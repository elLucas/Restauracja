using System.Collections.Generic;

namespace Restaurant.DTO
{
    public abstract class BaseDto
    {
        public DtoModel Model { get; set; }
        public Dictionary<string, object> ExtendedProperties { get; set; }
    }
}
