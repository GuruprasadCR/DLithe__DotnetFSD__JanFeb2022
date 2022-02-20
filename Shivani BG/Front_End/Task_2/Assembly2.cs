using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class Assembly2
    {
        public string var1;
        static void Main(String[] args)
        {
            Assembly2 airtmatic = new Assembly2();
            airtmatic.var1 = "addition";
            Console.WriteLine(airtmatic.var1);
        }
    }
}