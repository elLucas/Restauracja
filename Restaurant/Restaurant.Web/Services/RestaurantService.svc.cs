using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Restaurant.DTO;

namespace Restaurant.Web.Services
{
    [ServiceContract(Namespace = "")]
    [SilverlightFaultBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestaurantService
    {
        [OperationContract]
        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }

        [OperationContract]
        public string AppName()
        {
            return "Restauracja";
        }

        [OperationContract]
        public WorkerDto Login(short pinNumber)
        {
            return new WorkerDto()
                       {
                           Id = pinNumber,
                           Name = "Imie " + pinNumber,
                           Surname = "Nazwisko" + pinNumber,
                           Number = pinNumber
                       };
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
