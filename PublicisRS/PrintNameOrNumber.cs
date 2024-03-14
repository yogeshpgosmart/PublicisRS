using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicisRS
{
    public  class PrintNameOrNumber
    {
        public string Publicis(int number)
        {
            if (number % 3 == 0)
            {

                return "Publicis";

            }
            else
            {
                return "NotPass";
            }
        }
        public string ROar(int number)
        {
            if (number % 5 == 0)
            {

                return "rOar";
            }
            else
            {
                return "NotPass";
            }
        }
        public string PublicisrOar(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {

                return "PublicisrOar";

            }
            else
            {
                return "NotPass";
            }
        }

        public string PrintNumber(int number)
        {
            return number.ToString();
        }
    }
}
