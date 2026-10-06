int n = 3;
int head = 0;
int tail = 0;
int count = 0;
int?[] buffer = new int?[n];

void Log(int val)
{
    if (count < n)
    {
        buffer[head] = val;
        head = head+1 == n ? 0: head+1;
        count++;
        System.Console.WriteLine($"Logged {val}");
    }
    else
    {
        System.Console.WriteLine("Buffer Full");

    }
}

void Read()
{
    if (count != 0){
        int? val = buffer[tail];
        buffer[tail] = null;
        tail = tail+1 == n ? 0: tail+1;
        count--;
        System.Console.WriteLine($"Read {val}");
    }
    else
    {
        System.Console.WriteLine("Buffer Empty");
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
