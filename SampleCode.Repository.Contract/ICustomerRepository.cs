using SampleCode.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Repository.Contract
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerData> GetAll();
        CustomerData Get(int id);
        void Insert(CustomerData data);
        void Update(CustomerData data);
        void Delete(int id);
        void Save();
    }
}
