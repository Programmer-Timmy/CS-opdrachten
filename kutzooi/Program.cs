using System.Reflection.Metadata.Ecma335;

namespace kutzooi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    class car
    {
      public car()
        {
            
            
        }


        public string merk
        {
            get;
            set;
        }
        public string type
        {
            get;
            set;
        }
        public int bouwjaar
        {
            get;
            set;
        }
        public void show()
        {
            MessageBox.Show(merk + " "+ type + " "+ bouwjaar);
        }

    }
}