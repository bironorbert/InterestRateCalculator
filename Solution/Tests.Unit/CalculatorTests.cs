namespace Tests.Unit
{
  using InterestRateCalculator;
  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
  public class CalculatorTests
  {
    [TestMethod]
    public void GetLoanOverview_Test()
    {
      var options = new LoanOptions
      {
        Duration = 120,
        InterestRate = 5,
        LoanAmount = 500_000,
        AdministrationFeeFix = 10_000,
        AdministrationFeePercentage = 1
      };

      var overview = InterestRateCalculator.GetLoanOverview(options);

      Assert.AreEqual(136_393.09, overview.TotalInterestAmount, 0.01);
      Assert.AreEqual(5000, overview.AdministrationFees, 0.01);
      Assert.AreEqual(5303.28, overview.MonthlyCost, 0.01);
      Assert.AreEqual(2.83, overview.APR, 0.01);
    }
  }
}
