namespace StaticClass
{
    public class CommonTask
    {
        public static string GetComputerName()
        {
            return System.Environment.MachineName;
        }

        public static bool IsEmpty(string str)
        {
            if (str.Length > 0)
            {
                return false;
            }
            return true;
        }
    }
}
