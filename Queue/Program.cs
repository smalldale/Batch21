CustomQueue queue = new();

queue.AddRule("urgent", 10);
queue.AddRule("normal", 5);
queue.Enqueue("normal");
queue.Enqueue("urgent");
queue.Enqueue("other");
queue.Process();
queue.Process();
queue.Process();