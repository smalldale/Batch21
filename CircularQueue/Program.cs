CircularQueue circularQueue = new();

// Buffer overwrite true
circularQueue.Log(1);
circularQueue.Log(2);
circularQueue.Log(3);
circularQueue.Log(4); // overwrite 1
circularQueue.Read(); // 2
circularQueue.Read(); // 3
circularQueue.Read(); // 4

// Set capacity 2, resets existing data.
// Buffer overwrite false
circularQueue.SetCapacity(2);
circularQueue.SetOverwritePolicy(false);
circularQueue.Log(5);
circularQueue.Log(6);
circularQueue.Log(7); // full
circularQueue.Log(8); // full
circularQueue.Read(); // 5
circularQueue.Read(); // 6
circularQueue.Read(); // empty
circularQueue.Read(); // empty
