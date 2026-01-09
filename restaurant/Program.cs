namespace restaurant
{
    internal static class Program
    {
        /// <summary>
        ///  Kunanon Hareutaitam ID.134
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (args.Length > 0 && args[0].ToLower() == "-k")
                Application.Run(new KitchenFrom());
            else
                Application.Run(new WaiterForm());
        }
    }
}