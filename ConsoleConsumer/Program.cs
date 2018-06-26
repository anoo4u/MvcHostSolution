using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using Contracts;
namespace ConsoleConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IService> cf = new ChannelFactory<IService>(
                new WebHttpBinding(), "http://localhost:8000");

            cf.Endpoint.Behaviors.Add(new WebHttpBehavior());
            IService channel = cf.CreateChannel();

            Console.WriteLine(channel.GetMessage("Dhananjay Get"));
            Console.WriteLine(channel.PostMessage("Dhananjay Post"));

            Console.Read();

        }
    }
}
