using HogWildSystem.BLL;
using HogWildSystem.ViewModels;
using Microsoft.AspNetCore.Components;

namespace HogWildApp.Components.Pages.SamplePages
{
    public partial class WorkingVersion
    {
        #region Fields
        //  Property for holding any feedback messages
        private string feedback;

        //  This private field holds a reference to the WorkingVersionView instance
        private WorkingVersionView workingVersionView = new WorkingVersionView();
        #endregion

        #region Properties
        //  This attribute marks the property for dependency injection
        [Inject]
        //  This property provides access to the "WorkingVersionService"
        protected WorkingVersionService WorkingVersionService { get; set; }
        #endregion

        #region Methods
        private void GetWorkingVersion()
        {
            try
            {
                workingVersionView = WorkingVersionService.GetWorkingVersion();
            }
            catch(Exception ex)
            {
                //  capture any exception message for displaly
                feedback = ex.Message;
            }
        }

        #endregion
    }
}
