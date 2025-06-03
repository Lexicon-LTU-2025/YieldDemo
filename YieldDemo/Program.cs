


//var num = GetNumbers();
//IEnumerator<int> enumerator = num.GetEnumerator();

//while(enumerator.MoveNext())
//{
//    int item = enumerator.Current;
//    Console.WriteLine(item);
//}

foreach (int item in GetNumbers())
{
    Console.WriteLine(item);
}


//foreach (var item in GetNumOrdinary().Take(10))
//{
//    Console.WriteLine(item);
//}

foreach (var item in GetNumWithYield().Take(5))
{
    Console.WriteLine(item);
}

IEnumerable<int> GetNumWithYield()
{
    int i = 0;

    while (true)
    {
        yield return i++;
    }
}

IEnumerable<int> GetNumOrdinary()
{
    var i = 0;
    var res = new List<int>();

    while (i < 10000000)
    {
        res.Add(i++);
    }

    return res;

}

IEnumerable<int> GetNumbers()
{
    var li =  new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


    foreach (var item in li)
    {
        yield return item;
    }

    //yield return 1;
    //yield return 2;
    //yield return 3;
    //yield return 4;
}

IEnumerable<int> GetNumbers2()
{
    for (int i = 0; i < 20000; i++)
    {
        yield return i;
    }
}