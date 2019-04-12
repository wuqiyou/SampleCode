using SampleCode.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCode.Data;
using System.Data.Entity;

namespace SampleCode.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private SampleEntities SampleDbContext { get; set; }

        public CustomerRepository()
        {
            SampleDbContext = new SampleEntities();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerData Get(int id)
        {
            Customer customer = SampleDbContext.Customers.Find(id);
            return ConvertToData(customer);
        }

        public IEnumerable<CustomerData> GetAll()
        {
            return ConvertToData(SampleDbContext.Customers);
        }

        public void Insert(CustomerData data)
        {
            Customer customer = new Customer();
            Convert(data, customer);
            SampleDbContext.Customers.Add(customer);
        }

        public void Update(CustomerData data)
        {
            int id = (int)data.CustomerId;
            Customer customer = SampleDbContext.Customers.Find(id);
            Convert(data, customer);
            SampleDbContext.Entry(customer).State = EntityState.Modified;
        }

        public void Save()
        {
            SampleDbContext.SaveChanges();
        }

        public IEnumerable<ShipToInfoData> GetShipToesByCustomer(int id)
        {
            List<ShipToInfoData> shipToes = new List<ShipToInfoData>();
            IEnumerable<GetShipToesByCustomer_Result> items = SampleDbContext.GetShipToesByCustomer(id);
            foreach (GetShipToesByCustomer_Result item in items)
            {
                shipToes.Add(new ShipToInfoData { CustomerName = item.CustomerName, ShipToAddress = item.ShipToAddress });
            }
            return shipToes;
        }
        private CustomerData ConvertToData(Customer dbData)
        {
            CustomerData customerData = new CustomerData();
            customerData.CustomerId = dbData.CustomerId;
            customerData.CustomerName = dbData.CustomerName;
            //customerData.PhoneNumber = dbData.PhoneNumber;

            return customerData;
        }

        private void Convert(CustomerData data, Customer customer)
        {
            customer.CustomerName = data.CustomerName;
            //customerData.PhoneNumber = dbData.PhoneNumber;
        }

        private IEnumerable<CustomerData> ConvertToData(IEnumerable<Customer> dbList)
        {
            List<CustomerData> customers = new List<CustomerData>();
            foreach (Customer customer in dbList)
            {
                customers.Add(ConvertToData(customer));
            }

            return customers;
        }
    }
}
