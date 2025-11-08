// generation (range, repeat, empty)

//var result = Enumerable.Range(1, 20).Where(x => x % 2 == 0);
//foreach (var item in result)
//    Console.WriteLine(item);

//var result = Enumerable.Repeat("Hello", 8);
//foreach (var item in result)
//    Console.WriteLine(item);

var result = GetNames() ?? Enumerable.Empty<string>(); //null coalescing operator        ( it the metos was null the empty will be active )


static IEnumerable<string> GetNames()
{
    return null;
}
