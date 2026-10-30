int capacity = 3;
double warningThreshold = 0.66;
double criticalThreshold = 1.0;
int head = 0;
int tail = 0;
int count = 0;
int?[] buffer = new int?[capacity];

void Log(int val)
{
    if (count < capacity)
    {
        buffer[head] = val;
        head = (head + 1) % capacity;
        count++;
        Console.WriteLine($"Logged {val}");
        if (count >= capacity * criticalThreshold)
        {
            Console.WriteLine("Critical: Buffer Full");
        }
        else if (count >= capacity * warningThreshold)
        {
            Console.WriteLine("Warning: Buffer at 66%");
        }
    }
    else
    {
        buffer[head] = val;
        Console.WriteLine($"Overwritten oldest with {val}");
        head = (head + 1) % capacity;
        tail = (tail + 1) % capacity;
    }
}

void Read()
{
    if (count != 0)
    {
        int? val = buffer[tail];
        buffer[tail] = null;
        tail = (tail + 1) % capacity;
        count--;
        Console.WriteLine($"Read {val}");
    }
    else
    {
        Console.WriteLine("Buffer Empty");
    }
}



Log(1);
Log(2);
Log(3);
Log(4);
Read();
Read();
Read();
Read();
Read();
Log(5);
Log(6);
Log(7);
Log(8);
Read();
Read();
Read();
Read();
