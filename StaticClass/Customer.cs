namespace StaticClass
{
    public class Customer
    {
        public required string CustomerCode { get; set; }
        public required string CustomerName { get; set; }
        private string MachineName = "";
        public Customer()
        {
            MachineName = CommonTask.GetComputerName();
        }

        public void Insert()
        {
            if (!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
            {
                Console.WriteLine("Customer data inserted into database.");
            }
            else
            {
                Console.WriteLine("Data Missing.");
            }
        }
    }
}
