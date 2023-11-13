using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalLoanManager = new PersonalLoanManager();
            ICreditManager autoLoanManager = new AutoLoanManager();
            ICreditManager mortgageManager = new MortgageManager();
            ICreditManager merchantLoanManager = new MerchantLoanManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>
            {
                new SmsLoggerService(),
                new FileLoggerService()
            };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.SubmitApplication(personalLoanManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                personalLoanManager,
                autoLoanManager,
                mortgageManager,
                merchantLoanManager
            };


          //  applicationManager.PerformCreditPreCheck(credits);
        }
    }
}