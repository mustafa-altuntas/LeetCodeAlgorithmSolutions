



var listA = new List<int>() { 1, 5, 9 };
var listB = new List<int>() { 3, 0, 1 };
//var outputs = new List<int>() { 4, 5, 10 };

for (int i = 0; i < listA.Count; i++)
{
    var a = listA[i];
    var b = listB[i];
    var output = GetSum(a,b);
    Console.WriteLine($" {a} sum {b} = {output}  ");
}







int GetSum(int a, int b)
{
    if (a == 0) return b;
    if (b == 0) return a;

    while (b != 0)
    {
        var temp = (a & b) << 1;
        a = (a ^ b);
        b = temp;
    }
    return a;
}








