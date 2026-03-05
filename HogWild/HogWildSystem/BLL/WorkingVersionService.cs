#nullable disable
using HogWildSystem.DAL;
using HogWildSystem.Entities;
using HogWildSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogWildSystem.BLL
{
    public class WorkingVersionService
    {
        #region Fields
        //  hog wild context
        private readonly HogWildContext _hogWildContext;
        #endregion


        //  Constructor for the WorkingVersionService CLass
        internal WorkingVersionService(HogWildContext hogWildContext)
        {
            //  initialize the _hogWildContext field with the provided
            //      HogWildContext instance
            _hogWildContext = hogWildContext;
        }

        //  This method retrieves the working version record
        public WorkingVersionView GetWorkingVersion()
        {
            return _hogWildContext.WorkingVersions
                    .Select(x => new WorkingVersionView
                                {
                                    VersionID = x.VersionId,
                                    Major = x.Major,
                                    Minor = x.Minor,
                                    Build = x.Build,
                                    Revision = x.Revision,
                                    AsOfDate = x.AsOfDate,
                                    Comments = x.Comments
                                }
                            ).FirstOrDefault();

        }
    }
}
