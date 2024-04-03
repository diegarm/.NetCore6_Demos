// CS0854.cs (10,48)
using System;
using System.Linq.Expressions;

public class Test
{
    public static int ModAdd2(int x = 3, int y = 4, params int[] b) { return 0; }

    static void Main()
    {
        Expression<Func<int>> testExpr = () => ModAdd2();
        Console.WriteLine(testExpr);
    }
}