// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine(MyClass.magic(1));
Console.WriteLine(MyClass.magic(2));
Console.WriteLine(MyClass.magic(3));
Console.ReadLine();

static class MyClass
{
    public static int magic(uint x, uint y) {
        return (BitOperations.PopCount(x) + BitOperations.PopCount(y));
    }
    public static int magic(uint x) {
        return magic(x, x);
    }
}