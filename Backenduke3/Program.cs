using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Backenduke3;

class Program
{
    public static expressionMath expMath = new expressionMath();
    public static twoInputMath calc = new twoInputMath();
    static void Main(string[] args)
    {

        Console.WriteLine("Mathbot activated, select mode(1,2,3):\n" +
                        "1. Two factor math.\n" +
                        "2. Expression math.\n" +
                        "3. Quit.");
        Selection();
    }
    public static void Selection()
    {
        int chosenOption;

        while (!int.TryParse(Console.ReadLine(), out chosenOption))
        {
            Console.WriteLine("Please enter a valid number:");
        }
        switch (chosenOption)
        {
            case 1:
                {
                    decimal inputA = calc.getNumberA();
                    decimal inputB = calc.getNumberB();
                    calc.getOperator();
                    calc.CalculateTwo(inputA, inputB);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Future feature");
                    expMath.getExpression();
                    break;
                }

            case 3: break;
        }
    }
}



public class twoInputMath()
{
    string? operatorInput;
    char chosenOperator;
    decimal inputA;
    decimal inputB;
    decimal? result;
    public decimal getNumberA()
    {
        Console.WriteLine("Input first number:");
        while (!Decimal.TryParse(Console.ReadLine(), out inputA))
        {
            Console.WriteLine("Please enter a valid number:");
        }
        Console.WriteLine(inputA);
        return inputA;
    }

    public decimal getNumberB()
    {
        Console.WriteLine("Input second number:");
        while (!Decimal.TryParse(Console.ReadLine(), out inputB))
        {
            Console.WriteLine("Please enter a valid number:");
        }
        Console.WriteLine(inputB);
        return inputB;
    }

    public void getOperator()
    {
        Console.WriteLine("Select which operation you want to do, 'add', 'subtract', 'multiply' or 'divide'");
        operatorInput = Console.ReadLine();
        switch (operatorInput)
        {
            case "add":
                {
                    chosenOperator = '+';
                    Console.WriteLine(chosenOperator);
                    break;
                }
            case "subtract":
                {
                    chosenOperator = '-';
                    Console.WriteLine(chosenOperator);
                    break;
                }
            case "multiply":
                {
                    chosenOperator = '*';
                    Console.WriteLine(chosenOperator);
                    break;
                }
            case "divide":
                {
                    chosenOperator = '/';
                    Console.WriteLine(chosenOperator);
                    break;
                }
            default:
                Console.WriteLine("That is not a valid operator, 'add', 'subtract', 'multiply' or 'divide'!");
                getOperator();
                break;
        }
    }
    public void CalculateTwo(decimal inputA, decimal inputB)
    {
        switch (chosenOperator)
        {
            case '+':
                {
                    result = inputA + inputB;
                    Console.WriteLine($"{inputA}+{inputB}={result}");
                    break;
                }
            case '-':
                {
                    result = inputA - inputB;
                    Console.WriteLine($"{inputA}-{inputB}={result}");
                    break;
                }
            case '*':
                {
                    result = inputA * inputB;
                    Console.WriteLine($"{inputA}*{inputB}={result}");
                    break;
                }
            case '/':
                {
                    result = inputA / inputB;
                    Console.WriteLine($"{inputA}/{inputB}={result}");
                    break;
                }
        }
    }
}

public class expressionMath()
{

    string input;
    public List<char> mathExpression = new();
    public void getExpression()
    {
        input = Console.ReadLine();
        foreach (char symbol in input)
        {
            mathExpression.Add(symbol);
        }
        formatList();
    }
    public void formatList()
    {
        Console.WriteLine("Formatted:");
        char[] validCharacters = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/', '.', '^', '(', ')'};
        for (int i = 0; i < mathExpression.Count; i++)
        {
            bool valid = false;
            foreach (char validChar in validCharacters)
            {
                if (mathExpression[i] == validChar)
                {
                    valid = true;
                    break;
                }
            }
            if (!valid)
            {
                mathExpression.RemoveAt(i);
                if (i > 0) i--;
            }
        }
        Console.WriteLine(string.Join("", mathExpression));
    }
}