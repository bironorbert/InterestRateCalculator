using CommandLine;

namespace InterestRateCalculator
{
  public class LoanOptions
  {
    [Value(0, HelpText = "The amount of loan.")]
    public int LoanAmount { get; set; }

    [Value(1, HelpText = "The duration of loan in months.")]
    public int Duration { get; set; }

    [Option('i', Required = false, Default = 5, HelpText = "The interest rate in %.")]
    public double InterestRate { get; set; }

    [Option('a', Required = false, Default = 1, HelpText = "The administration fee in %.")]
    public double AdministrationFeePercentage { get; set; }

    [Option('f', Required = false, Default = 10000, HelpText = "The administration fee as a fix value.")]
    public int AdministrationFeeFix { get; set; }
  }
}
