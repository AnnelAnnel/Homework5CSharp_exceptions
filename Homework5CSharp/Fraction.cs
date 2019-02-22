using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5CSharp
{
    public class Fraction
    {
        public int x { get; set; }
        public int y { get; set; }
        public Fraction()
        {
            this.x = 1;
            this.y = 4;
        }

        public Fraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int division()
        {
            int result;
            result = this.x / this.y;
            return result;
            //try
            //{
            //   result = this.x / this.y;
            //   return result;             
            //}
            //finally
            //{

            //}

            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //    return -1;
            //}            
        }


    }
}
