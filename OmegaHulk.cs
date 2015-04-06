using System;

//issues 5 through 17
// issues 5 - 9 2014
// issues 10 - 17 2015

// If you enter a number that is not
// 5 through 17 give positive response
//

class OmegaHulk {
  static void Main() {
    int issue, year;

    const int MAX_ISSUE = 17;
    const int MIN_ISSUE = 5;
    const int MAX_YEAR = 2015;
    const int MIN_YEAR = 2014;

    string issueString, yearString;

    Console.WriteLine("*************************");
    Console.WriteLine("Hello, please enter issue");
    Console.WriteLine("*************************");
    issueString = Console.ReadLine();
    issue = int.Parse(issueString);
    if (issue < MIN_ISSUE) {
      Console.WriteLine (
      "This issue came out before Omega Hulk storyline"
      );
      issue = MIN_ISSUE;
    }
    if (issue > MAX_ISSUE) {
      Console.WriteLine(
      "This issue came out after Omega Hulk storyline"
      );
      issue = MAX_ISSUE;
    }

    Console.WriteLine("**************************");
    Console.WriteLine("Hello, please enter a year");
    Console.WriteLine("**************************");
    yearString = Console.ReadLine();
    year = int.Parse(yearString);
    if (year < MIN_YEAR) {
      Console.WriteLine ("Not Omega Hulk, issue too old");
      year = MIN_YEAR;
    }
    if (year > MAX_YEAR) {
      Console.WriteLine("Not Omega Hulk, issue too recent");
      year = MAX_YEAR;
    }
    Console.WriteLine("So you're asking about Omega Hulk issue number " + issue + " Released in the year " + year + "?");
  }
}
