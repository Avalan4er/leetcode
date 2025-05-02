using System.Collections.Generic;

var n = 31;
var m = 34;
var f = Fact(n + m) / (Fact(n + m) - Fact(m));

Console.WriteLine(f);

int Fact(int x)
{
    return Enumerable.Range(1, x).Aggregate((acc, x) => acc * x);
}