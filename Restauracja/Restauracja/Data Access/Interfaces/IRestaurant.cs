using System;
using System.Collections.Generic;
using Restauracja.ServerDTO;

namespace Restauracja.Data_Access.Interfaces
{
    public interface IRestaurant
    {
        List<TableDTO> GetAllTables();

        TableDTO GetTable(int id);
    }
}
