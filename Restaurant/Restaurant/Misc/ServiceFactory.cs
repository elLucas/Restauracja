using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Windows;
using Restaurant.WebService;

namespace Restaurant.Misc
{
    public class ServiceFactory
    {
        public static RestaurantServiceClient CreateClient()
        {
            Binding binding = new BasicHttpBinding();
            var endpoint =
                new EndpointAddress(new Uri(Application.Current.Host.Source, "../Services/RestaurantService.svc"));
            var client = new RestaurantServiceClient(binding, endpoint);
            return client;
        }
    }
}