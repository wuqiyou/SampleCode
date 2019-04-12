using SampleCode.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Service.Contract
{
    public interface ICustomerService
    {
        IEnumerable<CustomerObj> GetAll();
        CustomerObj Get(int id);
        CustomerObj GetNew();
        void Insert(CustomerObj customer);
        void Update(CustomerObj customer);

    }
}
