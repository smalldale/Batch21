var myList = new CustomLinkedList();

// 1. Add filtering: Keep only numbers greater than 1
myList.AddFilter(x => x > 1);

// 2. Set custom sorting: Descending order (largest to smallest)
myList.SetSorting((a, b) => b.CompareTo(a));

// Appending values out of order
myList.Append(5);
myList.Append(1); // Will be filtered out (> 1 rule)
myList.Append(8);
myList.Append(3);

// 3. Print
myList.Print();        // Output: Sequence: 8 -> 5 -> 3
myList.PrintReverse(); // Output: Reverse: 3 -> 5 -> 8