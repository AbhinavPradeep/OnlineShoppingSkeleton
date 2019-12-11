using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace OnlineShoppingSkeleton
{
    public class Order
    {
        public Item item {get;set;}
        public Address address{get;set;}
    }
}