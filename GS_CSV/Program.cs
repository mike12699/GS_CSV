using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GS_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            addRecord("124", "Mercy", "56", "results.txt");
        }

        public static void addRecord(string ID, string Name, string Age, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(ID + "," + Name + "," + Age);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Bad program", ex);
            }
        }
    }
}
