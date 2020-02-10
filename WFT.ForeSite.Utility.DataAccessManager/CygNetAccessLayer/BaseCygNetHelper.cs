using System;
using System.Collections.Generic;
using System.Text;
using WFT.ForeSite.Utility.Comman.Interface;
using WFT.ForeSite.Utility.Comman.Model;


namespace WFT.ForeSite.Utility.DataAccessManager.CygNetAccessLayer
{
    public class BaseCygNetHelper
    {
        public CygNet.COMAPI.Core.DomainSiteService GetDomainSiteServiceFromCOMAPI(ICygNetModel cygNetModel)
        {
           return new CygNet.COMAPI.Core.DomainSiteService(cygNetModel.Domain, cygNetModel.Site, cygNetModel.Service);
        }
        public CygNet.Data.Core.DomainSiteService GetDomainSiteServiceFromCygNetCore(ICygNetModel cygNetModel)
        {
            return new CygNet.Data.Core.DomainSiteService(cygNetModel.Domain, cygNetModel.Site, cygNetModel.Service);
        }
    }
}
