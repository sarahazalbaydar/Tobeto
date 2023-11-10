namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager housingCreditManager = new HousingCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager merchantCreditManager = new MerchantCreditManager();

            List<ILoggerService> loggerServices1 = new List<ILoggerService>()
            {
                new DatabaseLoggerService(),
                new SmsLoggerService()
            };

            List<ILoggerService> loggerServices2 = new List<ILoggerService>()
            {
                new FileLoggerService(),
                new SmsLoggerService()
            };

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                housingCreditManager,
                vehicleCreditManager,
                consumerCreditManager
            };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.CreditInformation(credits);
            Console.WriteLine("--------------");
            //applicationManager.ToApply(vehicleCreditManager, loggerServices1);
            //applicationManager.ToApply(consumerCreditManager, loggerServices2);

        }
    }
}