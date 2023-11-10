using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        public void ToApply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();

            foreach (var logger in loggerServices)
            {
                logger.Log();
            }

        }

        public void CreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
