namespace L3
{
    // The program itself
    internal static class Program
    {
        //  The main entry point for the application.
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // Init
            Form1 form = new(); // new form reference
            Application.Run(form); // run
        }
    }
}