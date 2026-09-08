# Backend uke 3, oppgave: 
I denne oppgaven skal dere modellere en klasse som demonstrerer metoder med ulike overloads, og designe en programflyt som kaller de riktige metodene basert på brukerens input.
Forslag til programidé

Et naturlig eksempel kan være å lage et kalkulatorprogram som:

    Spør brukeren hvilken operasjon de ønsker å utføre (f.eks. addisjon, subtraksjon, multiplikasjon, divisjon).

    Ber brukeren oppgi dataene som operasjonen skal kjøres på.

    Utfører operasjonen ved å kalle riktig overload av en metode.

For å gjøre det mer interessant kan dere:

    Gi brukeren mulighet til å skrive inn flere tall i samme input.

    Velge et skilletegn (f.eks. komma eller mellomrom) for å separere tallene.

    Parse input-strengen og konvertere tallene til riktig datatype (int, double osv.) før dere kjører operasjonen.

Tips til utvidelse

    While-loop: La programmet kjøre kontinuerlig til brukeren selv velger å avslutte.

    Overloads: Definer metoder med samme navn, men forskjellige parameterlister – f.eks. en versjon som tar to tall, og en annen som tar en liste med tall.

    Parsing og stringmanipulering: Utforsk metoder i System.String (som .Split()) og konvertering med int.Parse() eller double.TryParse().

    Samlinger: Vurder å bruke List<T> eller arrays for å håndtere flere tall dynamisk.

Arbeidsmåte

    Tegn et flytskjema som viser hvordan brukerens input fører til kall på de forskjellige overloads.

    Skriv pseudokode som beskriver logikken steg for steg.

    Implementer programmet i C#.

Dere står fritt til å lage en annen løsning enn en kalkulator, så lenge dere demonstrerer:

    en modellert klasse

    overloading av metoder

    og en tydelig programflyt basert på brukerinput.

Lykke til – og tenk gjerne på hvordan dere kan utvide programmet utover det mest grunnleggende!

# Programflow
1. hvilken regnemetode ønsker bruker å bruke
2. bruker velger utifra liste
    1. spør bruker om 2 tall
    2. spør bruker om operator
    3. programmet regner ut

    1. bruker gir input, programmet vil kun godta formatet "n+n-n*n/n" eller "n + n...."
    2. programmet følger regnerekkefølge, leter etter *+-/, tar det som står på hver side av tegnet(og tegnet selv) inn i korrekt funksjon, og putter resultatet tilbake på plassen som tegnet og tallene sto

    - hele strengen i en liste, samt en if blokk, if multiplikasjon løs det først, ta bort faktorene og operator, putt ny verdi inn i listen, kjør om igjen til listen ikke inneholder spesialtegn(evt lage liste med aksepterte tegn)

# Pseudokode
```csharp
Class Program:
 Console.Writeline("Mathbot activated, select mode(1,2,3):\n" + 
                    "1. Two factor math.\n" +
                    "2. Expression math.\n" +
                    "3. Quit.")
Selection()

public class Selection()
{
int selection;
 while (!int.TryParse(Console.ReadLine)out selection)
{
    Console.WriteLine("Please enter a valid number:");
}
switch (selection){
    case 1: twoInputMath.getNumberA()
            twoInputMath.getNumberB()
            twoInputMath.calculateTwo()
    case 2: expressionMath.getExpression()
    case 3: break;
}
}

public class twoInputMath()
{
    public decimal inputA {get; set;}

    public decimal getNumberA()
    {
        while (!Decimal.TryParse(Console.ReadLine)out inputA)
        {
            Console.WriteLine("Please enter a valid number:");
        }
        return inputA;
    }
    public decimal inputB {get; set;}
    public decimal getNumberB()
    {
        while (!Decimal.TryParse(Console.ReadLine)out inputB)
        {
            Console.WriteLine("Please enter a valid number:");
        }
        return inputB;
    }
    public string operator {get; set;};
    public string getOperator()
    {
        Console.Writeline("Select which operation you want to do, 'add', 'subtract', 'multiply' or 'divide")
        switch(console.ReadLine)
            case add: operator = +
            case subtract: operator = -
            case multiply: operator = *
            case divide: operator = /
            default: writeline: ("that is not a valid operator") getOperator()
    }
    public void CalculateTwo(){
    switch (operator)
    case +: decimal result = (inputA + inputB)
    Console.Writeline {inputA}+{inputB}=Result
    ...
    ...
    ...
    }
}    
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

```    
