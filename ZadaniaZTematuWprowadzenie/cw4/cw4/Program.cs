using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw4
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static bool IsThereAnXInTheTable(int[] tablica, int x)
        {
            if(tablica.Contains(x))
            {
                return true;
            }
            return false;
        }
    }
}
