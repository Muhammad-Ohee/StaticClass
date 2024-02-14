//Console.WriteLine("Hello, OS");

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryMaster countryMaster = new CountryMaster() 
            {
                CountryCode = "OS",
                CountryName = "OS"
            };

            Customer customer = new Customer() 
            {
                CustomerCode = "C004",
                CustomerName = "OS"
            };

            //Console.WriteLine(countryMaster.CountryName);
            countryMaster.Insert();
            customer.Insert();

        }
    }
}