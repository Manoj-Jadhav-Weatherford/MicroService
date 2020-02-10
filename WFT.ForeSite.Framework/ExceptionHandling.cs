using System;
using System.Collections.Generic;
using System.Text;

namespace WFT.ForeSite.Framework
{

    public static class ExceptionHandling
        {
        public static void Process<T>(Action action)
        {
            if (action == null) throw new ArgumentNullException("action");
            try
            {
                action();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T ProcessReturn<T>(Func<T> action) 
        {
            if (action == null) throw new ArgumentNullException("action");
            try
            {
                return action();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
