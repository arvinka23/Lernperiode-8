using System.Collections.Generic;

public class History
{
    private List<string> calculations = new List<string>();

    public void AddCalculation(string calculation)
    {
        calculations.Add(calculation);
    }

    public List<string> GetHistory() => new List<string>(calculations);
}
