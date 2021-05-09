using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    public class OutVsRef
    {
        public static void RefFoo(ref int inputValue)
        {
            inputValue = inputValue + 20;
        }

        /// <summary>
        /// This method is used for check out type variable
        /// Out is only one way
        /// Intialize value before using out variable
        /// </summary>
        /// <param name="inputValue"></param>
        public static void OutFoo(out int inputValue)
        {
            //must to be initialize before use out type of variable.
            inputValue = 5;

            inputValue = inputValue + 20;
        }

    }
}
