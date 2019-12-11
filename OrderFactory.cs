using System;
using System.IO;
using Newtonsoft.Json;

namespace OnlineShoppingSkeleton
{
    public class OrderFactory
    {
       public Order CreateOrder()
       {
           /* Createing objects */
           Order order = new Order();
           Item item = new Item();
           Address address = new Address();
           /* Defineing Item */
           order.item.ItemName = "RTX 2080";
           order.item.ItemDescription = "Graphics Card";
           /* Assigning Adress */
           order.item.ItemCost = 1699;
           order.address.Country = "Australia";
           order.address.State = "QLD";
           order.address.Street = "Nyes Crescent";
           order.address.HouseNum = 42;

           return order;
       }
    }
}