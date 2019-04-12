using SampleCode.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCode.Data;

namespace SampleCode.MockRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerData Get(int id)
        {
            return new CustomerData { CustomerId = 1, CustomerName = "cust 2" };
        }

        public IEnumerable<CustomerData> GetAll()
        {
            List<CustomerData> customers = new List<CustomerData>();
            customers.Add(new CustomerData { CustomerId = 1, CustomerName = "cust1" });
            customers.Add(new CustomerData { CustomerId = 2, CustomerName = "cust 2" });
            customers.Add(new CustomerData { CustomerId = 3, CustomerName = "cust3" });

            return customers;
        }

        public void Insert(CustomerData data)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerData data)
        {
            throw new NotImplementedException();
        }
        public void Save()
        { }
    }
}
