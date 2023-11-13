using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplicationManager
    {
        //Method injection
        public void SubmitApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            //başvuran bilgilerini değerlendirme

            creditManager.Calculate();

            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void PerformCreditPreCheck(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
