using CommandLine;
using System;
using System.Collections.Generic;

namespace InterestRateCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      var result = Parser.Default.ParseArguments<LoanOptions>(args)
                    .WithParsed(HandleLoan)
                    .WithNotParsed(HandleParseError);

      Console.ReadKey();
    }

    private static void HandleParseError(IEnumerable<Error> errors)
    {
      foreach(var error in errors)
      {
        Console.WriteLine(error);
      }
    }

    private static void HandleLoan(LoanOptions options)
    {
      var overview = InterestRateCalculator.GetLoanOverview(options);

      Console.WriteLine(overview);
    }
  }
}
