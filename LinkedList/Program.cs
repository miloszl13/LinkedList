using LinkedList;

var stack = new LinkedListStructure<int>();
stack.Add(1);
stack.Add(2);   
stack.Add(3);
stack.Add(4);

Console.WriteLine($"Stack peek : {stack.Peek()}");
Console.WriteLine();
stack.Print();