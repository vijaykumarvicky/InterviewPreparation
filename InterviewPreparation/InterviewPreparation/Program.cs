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
            try
            {
                FunThrowEx();
            }
            catch (Exception ex)
            {
                // When use throw ex then is will reset the stack trace of error.
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("\n end throw ex \n");
                Console.WriteLine("\n");
            }


            try
            {
                FunThrow();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n start throw \n");
                // When use throw then is will reset the stack trace of error.
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }


        /// <summary>
        /// Fun Throw Ex
        /// </summary>
        static void FunThrowEx()
        {
            try
            {
                Fun2();
            }
            catch (Exception ex)
            {
                //When use default throw ex then it will reset the stack trace of error.
                throw ex;
            }
        }

        /// <summary>
        /// Fun Throw
        /// </summary>
        static void FunThrow()
        {
            try
            {
                Fun2();
            }
            catch (Exception)
            {
                //When use default throw then is will help to show the actual stack trace of error.
                throw;
            }
        }

        static void Fun2()
        {
            throw new Exception("Exception from Fun2");
        }
    }
}
