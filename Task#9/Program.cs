var names = new List<string>{"Ali", "Abubakr", "Yusuf", "Ismoil", "Muhammad", "ttt"};

names.RemoveAll(name => name.Length <= 5);
foreach (var item in names)
{
    Console.WriteLine(item);
}
