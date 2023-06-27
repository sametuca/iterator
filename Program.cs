/*
An iterator is a method in C# which is used in an array or in collections like the list, etc. to retrieve elements one by one. Or in other words, 
we can say that an iterator is used to perform an iteration over the collections. 
This feature is introduced in C# 2.0. It uses the yield return statement to return the element from the collection at a time and it always remembers the current location of the iterator,
so when the next iteration takes place it will return the next element of the given collection. If you want to stop the iteration you will use the yield break statement. 
The return type of this method is IEnumerable, IEnumerable<T>, IEnumerator, or IEnumerator<T>. 
Which means by using iterator compiler will automatically create IEnumerable or IEnumerator interface for you there is no need to implement IEnumerable or IEnumerator interface in your class for using a foreach loop. 
When the compiler identifies an iterator in your class it will automatically create the current, MoveNext and dispose of the method of IEnumerable or IEnumerator interface.
*/

IEnumerable<int> GetNumbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
}

foreach (int number in GetNumbers())
{
    Console.WriteLine(number);
}


List<int> GetEvenNumbers(List<int> numbers)
{
    var List = new List<int>();
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            List.Add(number);
        }
    }
    return List;
}

foreach (var item in GetEvenNumbers(new List<int> { 1, 2, 3 }))
{
    Console.WriteLine(item);
}