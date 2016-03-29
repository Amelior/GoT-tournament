using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tournament
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Player
    {
        public string name;
        public List<int> tables = new List<int>();
        public List<string> houses = new List<string>();
        public List<int> places = new List<int>();
        public int connections = 0;

        public int NewTable = 0;

        public Player subst;
        public int subst_v = 0;
        public int new_con = 0;

        public string NewHouse = "";
    }
}
