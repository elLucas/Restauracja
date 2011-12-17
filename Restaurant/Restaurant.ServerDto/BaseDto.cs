using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.DTO
{
    public abstract class BaseDto
    {
        public DtoModel Model { get; set; }
        public Dictionary<string, object> ExtendedProperties { get; set; }
    }
}
