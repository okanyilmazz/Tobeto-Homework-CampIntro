namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.Id = 1;
            individualCustomer.CustomerNo = "12345";
            individualCustomer.FirstName = "Engin";
            individualCustomer.LastName = "Demiroğ";
            individualCustomer.NationalId = "12345678901";


            CoorporateCustomer coorporateCustomer = new CoorporateCustomer();
            coorporateCustomer.Id = 2;
            coorporateCustomer.CustomerNo = "54321";
            coorporateCustomer.CompanyName = "Kodlama.io";
            coorporateCustomer.TaxNo = "1234567890";

            // Gerçek Müşter - Tüzel Müşteri
            // SOLID

            Customer customer = new IndividualCustomer();
            Customer customer2 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer);
            customerManager.Add(coorporateCustomer);



        }
    }
}