using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Docusign_Api_Framework.Repo
{
    public class BaseRepo
    {
        protected static bool SafeRun(Action objAction)
        {

            try
            {
                objAction();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        protected static T SafeRun<T>(Func<T> objAction)
        {
            try
            {
                return objAction();
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}