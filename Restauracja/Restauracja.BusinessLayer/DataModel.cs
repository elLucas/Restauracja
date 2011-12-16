using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Restauracja.BusinessLayer
{
    public class DataModel
    {
        public const string MODELKEY = "model";
        public static RestaurantDataContext Instance
        {
            get
            {
                if (HttpContext.Current.Items[MODELKEY] == null)
                {
                    HttpContext.Current.Items[MODELKEY] = new RestaurantDataContext();
                }
                return (RestaurantDataContext) HttpContext.Current.Items[MODELKEY];
            }
        }
    }
}
