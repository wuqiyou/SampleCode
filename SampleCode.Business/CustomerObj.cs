using SampleCode.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.Business
{
    public class CustomerObj
    {
        public CustomerData Data { get; private set; }
        public CustomerObj(CustomerData data)
        {
            Data = data;
        }
        public object CustomerId
        {
            get { return Data.CustomerId; }
            set { Data.CustomerId = value; }
        }

        [Required(ErrorMessage = "Please enter customer name"), MaxLength(50)]
        [Display(Name = "Customer Name:")]
        public string CustomerName
        {
            get { return Data.CustomerName; }
            set { Data.CustomerName = value; }
        }
        [StringLength(6, ErrorMessage ="Maximum 6")]
        public string PhoneNumber
        {
            get { return Data.PhoneNumber; }
            set { Data.PhoneNumber = value; }
        }
    }
}
