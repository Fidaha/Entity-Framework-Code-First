namespace Savings.Models
{
    public class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public double Amount { get; set; }
        public double Rate { get; set; }
        public bool IsRateByMonth { get; set; }  // true par mois false par an


        public SavingAccount(double amount, double rate, bool isRateByMonth)
        {
            IsRateByMonth = isRateByMonth;
            Amount = amount;
            Rate = rate;
        }
    }

}
