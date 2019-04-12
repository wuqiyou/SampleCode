using SampleCode.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCode.Business;
using SampleCode.Repository.Contract;
using SampleCode.Data;
using SampleCode.Repository;

namespace SampleCode.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository Repository { get; set; }
        public CustomerService()
        {
            Repository = new CustomerRepository();
        }
        public CustomerObj Get(int id)
        {
            CustomerData data = Repository.Get(id);
            return new CustomerObj(data);
        }

        public IEnumerable<CustomerObj> GetAll()
        {
            List<CustomerObj> customers = new List<CustomerObj>();

            foreach (CustomerData data in Repository.GetAll())
            {
                customers.Add(new CustomerObj(data));
            }

            return customers;
        }

        public CustomerObj GetNew()
        {
            CustomerData data = new CustomerData();
            return new CustomerObj(data);
        }

        public void Insert(CustomerObj customer)
        {
            Repository.Insert(customer.Data);
            Repository.Save();
        }
        public void Update(CustomerObj customer)
        {
            Repository.Update(customer.Data);
            Repository.Save();
        }
    }
}
