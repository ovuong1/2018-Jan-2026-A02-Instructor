using HogWildSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogWildSystem.BLL
{
    public class CustomerService
    {
        #region Fields
        //  hog wild context
        private readonly HogWildContext _hogWildContext;
        #endregion


        //  Constructor for the WorkingVersionService CLass
        internal CustomerService(HogWildContext hogWildContext)
        {
            //  initialize the _hogWildContext field with the provided
            //      HogWildContext instance
            _hogWildContext = hogWildContext;
        }
    }
}
