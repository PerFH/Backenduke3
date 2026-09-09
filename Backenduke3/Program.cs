using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Backenduke3;

class Program
{
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
                calc.getNumberA();
                calc.getNumberB();
                calc.getOperator();
                calc.CalculateTwo(calc.getNumberA, calc.getNumberB, calc.getOperator);
                break;
            }
            case 2:
                {
                Console.WriteLine("Future feature");
                //expressionMath.getExpression();
                break;
                } 

            case 3: break;
        }
    }
}



public class twoInputMath()
{
    static char chosenOperator;
    decimal inputA;
    decimal inputB;
    char 
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
        while (!char.TryParse(Console.ReadLine(), out chosenOperator))
        {
            Console.WriteLine("Please enter a valid number:");
        }
        switch (chosenOperator)
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
            default: Console.WriteLine("That is not a valid operator, 'add', 'subtract', 'multiply' or 'divide'!"); 
            getOperator();
            break;
        }
    }
    public void CalculateTwo(decimal inputA, decimal inputB, char chosenOperator)
    {
        switch (chosenOperator)
        {
        case '+':
            {
                decimal result = inputA + inputB;
                Console.WriteLine($"{inputA}+{inputB}={result}");
                break;  
            }
        case '-':
            {
                decimal result = inputA - inputB;
                Console.WriteLine($"{inputA}-{inputB}={result}");
                break;  
            }
        case '*':
            {
                decimal result = inputA * inputB;
                Console.WriteLine($"{inputA}*{inputB}={result}");
                break;  
            }
        case '/':                
            {
                decimal result = inputA / inputB;
                Console.WriteLine($"{inputA}/{inputB}={result}");
                break;  
            }
        }
    }
}



/*
    public class expressionMath()
    {
        public List<string> mathExpression
        public void getExpression()
        {
            input = console.ReadLine()
        foreach char symbol in input
        mathExpression.Add
    }
        public void formatList()
        {
            for (int i = 0; i < mathExpression.Count; i++)
                if char.IsWhiteSpace(mathExpression[i])
                    mathExpression.RemoveAt(i)
                    i--
        }
        public void mathIsMathing
        {
        for loop, finn tegn i lista, ta det som er før og etter, gjør dette om til inputA+B samt operator, kall på funksjoner, og oppdater tegnet med resultatet og fjern de 2 faktorene, kjør om igjen til liste plass 2 ikke eksisterer
        }
    }
*/