using System;

namespace InterestRateCalculator
{
  public static class InterestRateCalculator
  {
    public static LoanOverview GetLoanOverview(LoanOptions options)
    {
      var interestRate = options.InterestRate / 100 / 12;
      var administrationFeePercentage = options.AdministrationFeePercentage / 100;
      var monthlyCost = GetMonthlyCost(options.LoanAmount, interestRate, options.Duration);
      var totalInterestAmount = GetTotalInterestAmount(options.LoanAmount, monthlyCost, options.Duration);
      var administrationFees = GetAdministrationFees(options.LoanAmount, administrationFeePercentage, options.AdministrationFeeFix);
      var apr = GetAPR(options.LoanAmount, totalInterestAmount, administrationFees, options.Duration);

      return new LoanOverview(apr, monthlyCost, administrationFees, totalInterestAmount);
    }

    private static double GetMonthlyCost(double loanAmount, double interestRate, int period)
    {
      return loanAmount * interestRate * Math.Pow(1 + interestRate, period) / (Math.Pow(1 + interestRate, period) - 1);
    }

    private static double GetTotalInterestAmount(double loanAmount, double monthlyCost, int duration)
    {
      return monthlyCost * duration - loanAmount;
    }

    private static double GetAdministrationFees(double loanAmount, double administrativePercentage, double administrativeFix)
    {
      return loanAmount * administrativePercentage > administrativeFix ? administrativeFix : loanAmount * administrativePercentage;
    }

    private static double GetAPR(double loanAmount, double totalInterestAmount, double fees, int period)
    {
      return (fees + totalInterestAmount) / loanAmount / (period / 12 * 365) * 365 * 100;
    }
  }
}
