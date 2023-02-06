using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipCounterApp.ClassLibrary
{
    static class ConvertUserInputData
    {
        public static bool CheckUserInputIsNotNullOrWhiteSpace(string inputDataToConvertInDecimal)
        {
            if (string.IsNullOrWhiteSpace(inputDataToConvertInDecimal)) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static decimal ConvertInputDataToDecimal(string inputDataToConvertInDecimal)
        {
            decimal output;
            _ = decimal.TryParse(inputDataToConvertInDecimal, out output);

            return output;
        }

    }
}
