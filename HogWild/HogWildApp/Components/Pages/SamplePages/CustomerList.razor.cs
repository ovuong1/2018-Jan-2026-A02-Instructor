using HogWildSystem.BLL;
using HogWildSystem.ViewModels;
using Microsoft.AspNetCore.Components;

namespace HogWildApp.Components.Pages.SamplePages
{
    public partial class CustomerList
    {
        #region Fields
        // the last name
        private string lastName = string.Empty;

        //  phone number
        private string phoneNumber = string.Empty;

        //  tell us if the search has been performed
        private bool noRecords;

        //  feedback message
        private string feedbackMessaage = string.Empty;

        //  error message
        private string errorMessage = string.Empty;

        //  has feedback
        private bool hasFeedback => !string.IsNullOrWhiteSpace(feedbackMessaage);

        //  has error
        private bool hasError => !string.IsNullOrWhiteSpace(errorMessage) || errorDetails.Count > 0;

        //  error details
        private List<string> errorDetails = new();
        #endregion

        #region Properties
        //  inject the CustomerService dependency
        [Inject] protected CustomerService? CustomerService { get; set; } = null;

        //  inject the NavigationManager dependency
        [Inject] protected NavigationManager? NavigationManager { get; set; } = null;

        //  customer search view
        protected List<CustomerSearchView> Customers { get; set; } = new();
        #endregion

        #region Methods
        // search for an existing customers
        private void Search()
        {

        }

        //  new customer
        private void New()
        {

        }

        //  edit the selected customer
        private void EditCustomer(int customerID)
        {

        }

        //  new invoice for selected customer
        private void NewInvoice(int customerID)
        {

        }


        #endregion
    }
}
