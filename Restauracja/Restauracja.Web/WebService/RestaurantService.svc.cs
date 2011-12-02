using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Restauracja.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestaurantService" in code, svc and config file together.
    public class RestaurantService : IRestaurantService
    {
        public void DoWork()
        {
        }


        public string GetAppName()
        {
            return "Restauracja";
        }
    }
}
