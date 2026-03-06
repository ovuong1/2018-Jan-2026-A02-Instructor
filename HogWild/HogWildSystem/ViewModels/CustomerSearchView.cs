using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogWildSystem.ViewModels
{
    public class CustomerSearchView
    {
        //  Customer ID
        public int CustomerID { get; set; }
        //	First Name
        public string FirstName { get; set; }
        //	Last Name
        public string LastName { get; set; }
        //	City
        public string City { get; set; }
        //	contact phone number
        public string Phone { get; set; }
        //	email address
        public string Email { get; set; }
        //	status ID.	Status value will uswe a dropdown and a "LookupView" Model
        public int StatusID { get; set; }
        //	Invoice.SubTotal + Invoice.Tax
        public decimal? TotalSales { get; set; } = 0;
    }
}
