public class CircularQueue
{
    private const int _capacity = 3;
    private const double _warningThreshold = 0.66;
    private const double _criticalThreshold = 1.0;
    private int _head = 0;
    private int _tail = 0;
    private int _count = 0;
    private int?[] _buffer = new int?[_capacity];
    private bool _overwrite = false;

    /// <summary>
    /// Sets the buffer capacity. Resets existing data.
    /// </summary>
    public void SetCapacity(int n)
    {
        _buffer = new int?[n];
        _head = 0;
        _tail = 0;
        _count = 0;
    }

    /// <summary>
    /// When true, full buffer overwrites oldest. 
    /// When false, full buffer rejects new entries.
    /// </summary>
    public void SetOverwritePolicy(bool isOverwriteEnabled)
    {
        _overwrite = isOverwriteEnabled;
    }

    void Log(int val)
    {
        if (_count < _capacity)
        {
            _buffer[_head] = val;
            _head = (_head + 1) % _capacity;
            _count++;
            Console.WriteLine($"Logged {val}");
            if (_count >= _capacity * _criticalThreshold)
            {
                Console.WriteLine("Critical: Buffer Full");
            }
            else if (_count >= _capacity * _warningThreshold)
            {
                Console.WriteLine("Warning: Buffer at 66%");
            }
        }
        else
        {
            if (_overwrite)
            {
                _buffer[_head] = val;
                Console.WriteLine($"Overwritten oldest with {val}");
                _head = (_head + 1) % _capacity;
                _tail = (_tail + 1) % _capacity;
            }
            else
            {
                Console.WriteLine($"Buffer Full");
            }
        }
    }

    void Read()
    {
        if (_count != 0)
        {
            int? val = _buffer[_tail];
            _buffer[_tail] = null;
            _tail = (_tail + 1) % _capacity;
            _count--;
            Console.WriteLine($"Read {val}");
        }
        else
        {
            Console.WriteLine("Buffer Empty");
        }
    }
}