using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace OnlineShoppingSkeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your name...");
            string CustomerName = Console.ReadLine();

            OrderFactory factory = new OrderFactory();
            Order order = new Order();

            order = factory.CreateOrder();

            string OrderInJSON = JsonConvert.SerializeObject(order,Formatting.Indented);
            System.Console.WriteLine(OrderInJSON);
        }
    }
}
