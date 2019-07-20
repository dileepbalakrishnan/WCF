using System;
using System.ServiceModel;
using PointsOfInterest;

namespace ServiceHosting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(PointsOfInterestService));
            host.Open();
            Console.WriteLine("Service started...");
            Console.ReadLine();
            host.Close();
        }
    }
}