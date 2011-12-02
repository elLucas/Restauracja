using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Restauracja.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestaurantService" in both code and config file together.
    [ServiceContract]
    public interface IRestaurantService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string GetAppName();
    }
}
