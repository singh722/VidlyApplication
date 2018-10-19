using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class CustomerModel
    {
        public IDictionary<int, Customer> Customers { get; set; }
        public CustomerModel()
        {
            this.Customers = new Dictionary<int, Customer>();
            this.Customers.Add(new KeyValuePair<int, Customer>(1, new Customer(1, "John Smith")));
            this.Customers.Add(new KeyValuePair<int, Customer>(2, new Customer(2, "Mark Taylor")));
        }
        public Customer GetCustomerById(int id)
        {
            if (Customers.TryGetValue(id, out Customer c))
                return c;
            else
                return null;
        }  
    }
}