using System;

class FinancialForecast
{
    // Recursive method to calculate future value
    public static double PredictFutureValue(double presentValue, double growthRate, int years)
    {
        // Base case: if no more years to grow, return the present value
        if (years == 0)
            return presentValue;

        // Recursive case: compute future value for one year less,
        // then apply growth rate
        return PredictFutureValue(presentValue, growthRate, years - 1) * (1 + growthRate);
    }

    static void Main()
    {
        // Initial parameters
        double initialInvestment = 1000.0;   // Present value
        double annualGrowthRate = 0.05;      // 5% growth rate
        int futureYears = 5;                 // Forecast for 5 years

        double futureValue = PredictFutureValue(initialInvestment, annualGrowthRate, futureYears);
        
        Console.WriteLine($"Future value after {futureYears} years is: {futureValue:F2}");
    }
}