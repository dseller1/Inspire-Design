using System;
using System.Text.RegularExpressions;

public class Validation
{
    public static bool validateNumber(string input)
    {
        bool valid = false;
        Regex rgx = new Regex("[^0-9]+");

        Match match = rgx.Match(input);
        if (!match.Success)
            valid = true;
        return valid;
    }

    public static bool validatePercent(string input)
    {
        bool valid = false;
        Regex rgx = new Regex("([^0-9][^$])+");

        Match match = rgx.Match(input);
        if (!match.Success)
            valid = true;
        return valid;
    }
}
