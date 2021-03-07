using System;

namespace InterestRateCalculator
{
  public class LoanOverview
  {
    public double APR { get; }

    public double MonthlyCost { get; }

    public double AdministrationFees { get; }

    public double TotalInterestAmount { get; }

    public LoanOverview(double apr, double monthlyCost, double administrationFees, double totalInterestAmount)
    {
      APR = apr;
      MonthlyCost = monthlyCost;
      AdministrationFees = administrationFees;
      TotalInterestAmount = totalInterestAmount;
    }

    public override string ToString()
    {
      return 
        $@"Monthly cost: {Math.Round(MonthlyCost, 2)}
Administrvative fees: {AdministrationFees}
Total interest amount: {Math.Round(TotalInterestAmount, 2)}
APR: {Math.Round(APR, 2)}";
    }
  }
}
