namespace StaticClass
{
    public class CountryMaster
    {
        public required string CountryCode { get; set; }
        public required string CountryName { get; set; }
        private string ComputerName
        {
            get
            {
                return CommonTask.GetComputerName();
            }
        }

        public void Insert()
        {
            if (!CommonTask.IsEmpty(CountryCode) && !CommonTask.IsEmpty(CountryName))
            {
                Console.WriteLine("Country data inserted into database.");
            }
            else
            {
                Console.WriteLine("Data Missing.");
            }
        }
    }
}
