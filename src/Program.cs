namespace RemoverByPattern
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                RemoverByPattern remover = new RemoverByPattern();
                remover.argument = args[0];
                Application.Run(remover);
            }
        }
    }
}
