using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipCounterApp.ClassLibrary
{
    public class CalculateData
    {
        public static decimal CalculateRisk(decimal entryPrice, decimal stopLoss)
        {
            decimal RiskCalculatedInDecimal = entryPrice - stopLoss;

            return RiskCalculatedInDecimal;
        }

        public static decimal CalculateReward(decimal exitPrice, decimal entryPrice) 
        {
            decimal RewardCalculatedInDecimal = exitPrice - entryPrice;

            return RewardCalculatedInDecimal;
        }
    }
}
