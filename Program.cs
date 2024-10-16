
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is positive"
        //...
        // ...
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);
        //...
        //...
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);
        //...
        //...
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);
        //...
        //...
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);
        //...
        //...
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');
        //...
        //...
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);


        DisplayDayOfWeek(4); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int x){
        if(x<0)
        Console.WriteLine("Your number is negative.");
        if(x==0)
        Console.WriteLine("Your number is zero");
        if(x>0)
        Console.WriteLine("Your number is positive.");
    }
    public static void FindMinimum(int x, int y, int z){
        if (x < y && x < z)
        Console.WriteLine("The minimum value is " + x + ".");
        else if(y < x && y < z)
        Console.WriteLine("The minimum value is " + y + ".");
        else if (z < x && z < y)
        Console.WriteLine("The minimum value is " + z + ".");
        else
        Console.WriteLine("There are two minimum values that are equal.");
    }
    public static void FindMaximum(int x, int y, int z){
    if (x > y && x > z)
    Console.WriteLine("The maximum value is " + x + ".");
    else if(y > x && y > z)
    Console.WriteLine("The maximum value is " + y + ".");
    else if (z > x && z > y)
    Console.WriteLine("The maximum value is " + z + ".");
    else
    Console.WriteLine("There are two maximum values that are equal.");
    }
    public static void IsDivisibleBy5(int m5){
        string notOrNotNot = "";
        if(m5%5 != 0)
        notOrNotNot = "not ";
        Console.WriteLine(m5 + " is " + notOrNotNot + "divisible by " + m5);
    }
    public static void CheckEvenOrOdd(int eoo){
        string eooWord = "odd";
        if(eoo%2 == 0)
        eooWord = "even";
        Console.WriteLine(eoo + " is an " + eooWord + " number.");
    }
    public static void CheckVowelOrConsonant(char onlyOne){
        string whatDoYouMean = "consonant";
        if(onlyOne.Equals('a')||onlyOne.Equals('e')||onlyOne.Equals('u')||onlyOne.Equals('o')||onlyOne.Equals('i')||onlyOne.Equals('A')||onlyOne.Equals('E')||onlyOne.Equals('U')||onlyOne.Equals('O')||onlyOne.Equals('I'))
        whatDoYouMean = "vowel";
        else if(onlyOne.Equals('y')||onlyOne.Equals('Y'))
        whatDoYouMean = "question";
        Console.WriteLine(onlyOne + " is a " + whatDoYouMean + ".");
    }
    public static void DisplayDayOfWeek(int t7){
        if(t7==0)
        Console.WriteLine("Sunday");
        if(t7==1)
        Console.WriteLine("Monday");
        if(t7==2)
        Console.WriteLine("Tuesday");
        if(t7==3)
        Console.WriteLine("Wednesday");
        if(t7==4)
        Console.WriteLine("Thursday");
        if(t7==5)
        Console.WriteLine("Friday");
        if(t7==6)
        Console.WriteLine("Saturday");
    }

}
