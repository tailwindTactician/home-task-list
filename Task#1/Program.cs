List<int> listA = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> listB = new List<int>() { 2, 3, 5 };

        bool containsAll = listB.All(x => listA.Contains(x));

        Console.WriteLine("listA содержит все элементы listB? " + containsAll);