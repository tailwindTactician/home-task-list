List<int> numbers = new List<int>() { 5, 2, 9, 1, 3 };

numbers.Sort();
numbers.Reverse();
Console.Write("Reversed numbers: ");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}