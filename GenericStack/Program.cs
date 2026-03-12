using System;

SimpleQueue<int> queue1 = new SimpleQueue<int>(3);
Console.WriteLine("=== int 큐 (용량: 3) ===");
queue1.Enqueue(10);
queue1.Enqueue(20);
queue1.Enqueue(30);
Console.WriteLine($"Enqueue: 10, 20, 30");
Console.WriteLine($"Count: {queue1.Count}, IsFull: {queue1.IsFull}");
queue1.Enqueue(40);
Console.WriteLine($"Peak: {queue1.Peek()}");
queue1.Dequeue();
queue1.Dequeue();
Console.WriteLine($"Dequeue: 10");
Console.WriteLine($"Dequeue: 20");
Console.WriteLine($"Count: {queue1.Count}, IsEmpty: {queue1.IsEmpty}");

Console.WriteLine("=== string 큐 (용량: 2) ===");
SimpleQueue<string> queue2 = new SimpleQueue<string>(2);
queue2.Enqueue("Hello");
queue2.Enqueue("World");
Console.WriteLine($"Enqueue: Hello, World");
queue2.Dequeue();
queue2.Dequeue();
Console.WriteLine("Dequeue: Hello");
Console.WriteLine("Dequeue: World");
queue2.Dequeue();
Console.WriteLine($"IsEmpty: {queue2.IsEmpty}");
