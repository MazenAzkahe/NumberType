using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_floatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("float Min is : " + flMin + "\nfloat Max is : " + flMax);
            float flVal = 1f / 3;
            double dlVal = 1d / 3;
            decimal dcVal = 1m / 3;
            Console.WriteLine(  "float : " + flVal+"\n"
                               + "double : " + dlVal + "\n"
                               + "decimal : " + dcVal);
            //Console.ReadKey();
        }
    }
}
