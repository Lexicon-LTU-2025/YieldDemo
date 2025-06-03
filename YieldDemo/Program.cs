
var num = GetNumbers();
IEnumerator<int> enumerator = num.GetEnumerator();

while(enumerator.MoveNext())
{
    int item = enumerator.Current;
    Console.WriteLine(item);
}

foreach(int item in GetNumbers())
{
    Console.WriteLine(item);
}


IEnumerable<int> GetNumbers()
{
    return new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
}