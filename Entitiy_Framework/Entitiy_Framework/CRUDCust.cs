using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy_Framework
{
    class CRUDCust
    {
        private NorthwindEntities entities = new NorthwindEntities();
        public void InsertCustomers(Customer nuevo)
        {
           
            entities.Customers.Add(nuevo);
            entities.SaveChanges();
            
            


        }
        public List<Customer> GetCustomers()
        {

            return entities.Customers.ToList();
        }

        public Customer GetCustomerById(string id)
        {
            return entities.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public void UpdateCustomer(string id,Customer customer2)
        {
            Customer customer = GetCustomerById(id);
            if (customer != null)
            {
                customer.CustomerID = customer2.CustomerID;
                customer.CompanyName = customer2.CompanyName;
                customer.ContactName = customer2.ContactName;
                customer.ContactTitle = customer2.ContactTitle;
                customer.Address = customer2.Address;
                customer.City = customer2.City;
                customer.Region = customer2.Region;
                customer.Phone = customer2.Phone;
                customer.Country = customer2.Country;
                customer.PostalCode = customer2.PostalCode;
                customer.Fax = customer2.Fax;             
                entities.SaveChanges();
            }
        }

        public void DeleteCustomer(string id)
        {
            var consulta = entities.Orders.Where(a => a.CustomerID == id);
            foreach (var con in consulta)
            {
                var consulta2 = entities.Order_Details.Where(a => a.OrderID == con.OrderID);
                foreach (var con2 in consulta2)
                {
                    entities.Order_Details.Remove(con2);

                }
                entities.Orders.Remove(con);

            }
           
            Customer temporal = GetCustomerById(id);

            entities.Customers.Remove(temporal);

            entities.SaveChanges();


        }

    }
}
