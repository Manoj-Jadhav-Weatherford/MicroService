using CygNet.COMAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using WFT.ForeSite.Framework;
using WFT.ForeSite.Utility.Comman.Interface;
using WFT.ForeSite.Utility.DataAccessManager.CygNetAccessLayer;

namespace WFT.ForeSite.Utility.BusinessManager
{
    public class CygNetBusinessManager
    {
        CygNetDataAccessManager cygNetDataAccessManager;
        public CygNetBusinessManager()
        {
            cygNetDataAccessManager = new CygNetDataAccessManager();
        }

        public IUisClient GetUisClient(ICygNetModel cygNetModel)
        {
            return ExceptionHandling.ProcessReturn(() => cygNetDataAccessManager.GetUisClient(cygNetModel));
        }
    }
}
