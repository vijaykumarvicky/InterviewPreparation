using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int refValue=0;
            int outValue;

            OutVsRef.RefFoo(ref refValue);

            Console.WriteLine(refValue);

            OutVsRef.OutFoo(out outValue);

            Console.WriteLine(outValue);

        }
    }
}
