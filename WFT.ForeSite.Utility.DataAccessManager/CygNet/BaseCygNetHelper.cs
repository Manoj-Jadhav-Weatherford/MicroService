using CygNet.COMAPI.Core;
using System;
using System.Collections.Generic;
using System.Text;
using WFT.ForeSite.Utility.Comman.Interface;
using WFT.ForeSite.Utility.Comman.Model;


namespace WFT.ForeSite.Utility.DataAccessManager.CygNet
{
    internal class BaseCygNetHelper
    {
        public DomainSiteService GetDomainSiteServiceFromCOMAPI(ICygNetModel cygNetModel)
        {
           return new DomainSiteService(cygNetModel.Domain, cygNetModel.Site, cygNetModel.Service);
        }
    }
}
