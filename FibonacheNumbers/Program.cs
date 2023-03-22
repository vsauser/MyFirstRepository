// See https://aka.ms/new-console-template for more information
var fibonacheNumbers = new FibonacheNumbers(1, 2);
var sum = fibonacheNumbers.Sum();
Console.WriteLine(sum);
Console.ReadLine();

class FibonacheNumbers
{
    private int _a;
    private int _b;

    public FibonacheNumbers(int a, int b)
    {
        _a = a;
        _b = b;
    }
    public int Sum()
    {
        return _a + _b;
    }
}