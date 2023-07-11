using Savings.Models;

namespace Savings.Services
{
    public class SavingCalculator
    {
        public static double ActualAmount(SavingAccount account)
        {
            // 3ans apres le depot 
            int nbIteration = 3;

            if (account.IsRateByMonth)
                nbIteration *= 12;

            double res = account.Amount;

            for(int i = 0; i < nbIteration; i++)
            {
                res = res * (1 + account.Rate);
            }

            return res; // montant actuel
        }
    }
}
