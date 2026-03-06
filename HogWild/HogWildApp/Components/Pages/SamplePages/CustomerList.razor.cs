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
        private string feedbackMessage = string.Empty;

        //  error message
        private string errorMessage = string.Empty;

        //  has feedback
        private bool hasFeedback => !string.IsNullOrWhiteSpace(feedbackMessage);

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
            //	clear previous error details and messages
            errorDetails.Clear();
            errorMessage = string.Empty;
            feedbackMessage = string.Empty;
            noRecords = false;

            //	wrap the service call in a try/catch to handle unexpected exceptions
            try
            {
                var result = CustomerService.GetCustomers(lastName, phoneNumber);
                if (result.IsSuccess)
                {
                    Customers = result.Value;
                }
                else
                {
                    Customers.Clear();
                    //  set noRecords
                    if (result.Errors.Any(e => e.Code == "No Customers"))
                    {
                        noRecords = true;
                    }
                    errorDetails = BlazorHelperClass.GetErrorMessages(result.Errors.ToList());
                }
            }
            catch (Exception ex)
            {
                //	capture any exception message for display
                errorMessage = ex.Message;
            }
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
