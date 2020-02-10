using CygNet.COMAPI.Client;
using CygNet.COMAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using WFT.ForeSite.Utility.Comman.Interface;

namespace WFT.ForeSite.Utility.DataAccessManager.CygNetAccessLayer
{
    public class CygNetDataAccessManager : BaseCygNetHelper
    {
        private ClientProxyManager clientProxyManager;

        public  CygNetDataAccessManager()
        {
            clientProxyManager = new ClientProxyManager();
        }

        public IUisClient GetUisClient(ICygNetModel cygNetMdoel)
        {
            var domainSiteService = GetDomainSiteServiceFromCOMAPI(cygNetMdoel);
            IUisClient uisClient = clientProxyManager.GetUisClient(domainSiteService);
            uisClient.Connect(domainSiteService);
            return uisClient;
        }
    }
}
