using System;
using TechTalk.SpecFlow.Assist.ValueRetrievers;

//Console.WriteLine("Choose an operator from the following list:");
//Console.WriteLine("\ta - Add");
//Console.WriteLine("\ts - Subtract");
//Console.WriteLine("\tm - Multiply");
//Console.WriteLine("\td - Divide");
//Console.WriteLine("\tf - Factorial");
//Console.WriteLine("\tt - Area of Triangle");
//Console.WriteLine("\tc - Area of Circle");
//Console.WriteLine("\t1 - MTBF");
//Console.WriteLine("\t2 - Availability");
//Console.WriteLine("\t3 - Basic Musa Failure Intensity");
//Console.WriteLine("\t4 - Basic Musa Average Number of Failures");
//Console.WriteLine("\t5 - Defect Density (Defects over KLOC)");
//Console.WriteLine("\t6 - SSI (4 arguments)");
//Console.WriteLine("\t7 - Logarithmic Musa Failure Intensity");
//Console.WriteLine("\t8 - Logarithmic Musa Average Number of Failures");

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, double num3, double num4, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = TriangleArea(num1, num2);
                break;
            case "c":
                result = CircleArea(num1);
                break;
            case "1":
                result = MTBF(num1, num2);
                break;
            case "2":
                result = Availability(num1, num2);
                break;
            case "3":
                result = BasicMusaCurrentFailureIntensity(num1, num2, num3);
                break;
            case "4":
                result = BasicMusaAverageNumberOfFailures(num1, num2, num3);
                break;
            case "5":
                result = DefectDensity(num1, num2);
                break;
            case "6":
                result = SSI(num1, num2, num3, num4);
                break;
            case "7":
                result = LogarithmicMusaCurrentFailureIntensity(num1, num2, num3);
                break;
            case "8":
                result = LogarithmicMusaCurrentFailureIntensity(num1, num2, num3);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    //public double Add(double num1, double num2)
    //{
    //    return (num1 + num2);
    //}
    public double Add(double num1, double num2)
    {
        // Check if string is "binary"
        string num12 = num1.ToString() + num2.ToString();
        foreach (char c in num12)
        {
            string allowableNumbers = "01";
            if (!allowableNumbers.Contains(c.ToString()))
                return (num1 + num2);
        }

        String n1 = num1.ToString();
        String n2 = num2.ToString();
        String n3 = n1 + n2;

        return Convert.ToInt32(n3, 2);
    }

    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {
        //if (num2 == 0 || num1 == 0)
        //{
        //    throw new ArgumentException("The second argument is 0!");
        //}

        if (num2 == 0 && num1 == 0)
        {
            return 1;
        }

        return (num1 / num2);
    }
    public double Factorial(double num1)
    {

        if (num1 < 0)
        {
            throw new ArgumentException("Argument is less than 0!");
        }
        else if (num1 % 1 != 0)
        {
            throw new ArgumentException("Argument is not a whole number!");
        }

        int i;
        int fact = 1;
        for (i = 1; i <= num1; i++)
        {
            fact = fact * i;
        }

        return fact;
    }
    public double TriangleArea(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            throw new ArgumentException("One of the argument is less than or equal to 0!");
        }
        return (0.5 * (num1 * num2));
    }
    public double CircleArea(double num1)
    {
        if (num1 <= 0)
        {
            throw new ArgumentException("Argument is less than or equal to 0!");
        }
        return (System.Math.PI * (num1 * num1));
    }
    public double UnknownFunctionA(double num1, double num2)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("The first argument is less than 0!");
        } else if (num2 > num1)
        {
            throw new ArgumentException("The second argument is greater than the first!");
        }
        return (Factorial(num1) / Factorial(num1 - num2));
    }
    public double UnknownFunctionB(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException("One of the argument is less than 0!");
        }
        else if (num2 > num1)
        {
            throw new ArgumentException("The second argument is greater than the first!");
        }
        return (Factorial(num1) / (Factorial(num1 - num2) * Factorial(num2)));
    }
    public double MTBF(double num1, double num2)
    {
        if (num1 < 0 || num2 <= 0)
        {
            throw new ArgumentException("One of the argument is invalid!");
        }
        return (num1 + num2);
    }
    public double Availability(double num1, double num2)
    {
        if (num1 < 0 || num2 <= 0)
        {
            throw new ArgumentException("One of the argument is invalid!");
        }
        else if (num1 > num2)
        {
            throw new ArgumentException("The MTTF is greater than the MTBF!");
        }
        return (num1 / num2);
    }
    public double BasicMusaCurrentFailureIntensity(double num1, double num2, double num3)
    {
        //num1 is lambda0, num2 is mu, num3 is v0
        if (num1 < 0 || num2 < 0 || num3 <= 0)
        {
            throw new ArgumentException("One of the argument is invalid!");
        }
        else if (num2 > num3)
        {
            throw new ArgumentException("mu is greater than v0!");
        }
        return (num1 * (1 - (num2 / num3)));
    }
    public double BasicMusaAverageNumberOfFailures(double num1, double num2, double num3)
    {
        //num1 is lambda0, num2 is tau, num3 is v0
        if (num1 < 0 || num2 < 0 || num3 <= 0)
        {
            throw new ArgumentException("One of the argument is invalid!");
        }
        return (num3 * (1 - Math.Exp((-1) * (num1 / num3) * num2)));
    }
    public double DefectDensity(double num1, double num2)
    {
        //num1 is defect count, num2 is KLOC
        if (num1 <= 0 || num2 <= 0) 
        {
            throw new ArgumentException("One of the argument is invalid!");
        }
        return (num1 / num2);
    }
    public double SSI (double num1, double num2, double num3, double num4)
    {
        // num1 is old SSI, num2 is CSI, num3 is deleted, num4 is changed
        return (num1 + num2 - num3 - num4);
    }
    public double LogarithmicMusaCurrentFailureIntensity(double num1, double num2, double num3)
    {
        //num1 is lambda0, num2 is mu, num3 is theta
        if (num1 < 0 || num2 < 0 || num3 <= 0)
        {
            throw new ArgumentException("One of the argument is invalid!");
        }
        return (num1 * Math.Exp((-1) * (num3 * num2)));
    }
    public double LogarithmicMusaAverageNumberOfFailures(double num1, double num2, double num3)
    {
        //num1 is lambda0, num2 is tau, num3 is theta
        if (num1 < 0 || num2 < 0 || num3 <= 0)
        {
            throw new ArgumentException("One of the argument is invalid!");
        }
        return ((1 / num3) * Math.Log((num1 * num2 * num3) + 1));
    }
}