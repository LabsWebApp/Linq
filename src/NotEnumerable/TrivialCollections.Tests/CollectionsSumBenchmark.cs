using BenchmarkDotNet.Attributes;
using TrivialCollections.SingleLinked;

namespace TrivialCollections.Tests;

[MemoryDiagnoser()]
public class CollectionsSumBenchmark
{
    private const int Size = 100_000;

    private List<int> _list;
    private readonly int[] _arr;
    private readonly TrivialStack<int> _stack;
   // private readonly TrivialStructStack<int> _sstack;
    private readonly TrivialQueue<int> _queue;


    public CollectionsSumBenchmark()
    {
        _list = Enumerable.Range(0, Size).ToList();
        _arr = Enumerable.Range(0, Size).ToArray();
        _stack = new TrivialStack<int>();
       // _sstack = new TrivialStructStack<int>();
        _queue = new TrivialQueue<int>();

        for (var i = 0; i < Size; i++)
        {
            _stack.Push(i);
            _queue.Enqueue(i);
        //    _sstack.Push(i);
        }
    }

    [Benchmark(Baseline = true)]
    public long ListSumTest() => _list.Sum();

    [Benchmark]
    public long ArraySumTest() => _arr.Sum();

    [Benchmark]
    public long StackSumTest()
    {
        var result = 0L;
        for (var i = 0; i < Size; i++) result += _stack.Pop();
        return result;
    }

    //[Benchmark]
    //public long StructStackSumTest()
    //{
    //    var result = 0L;
    //    for (var i = 0; i < Size; i++) result += _sstack.Pop();
    //    return result;
    //}

    [Benchmark]
    public long QueueSumTest()
    {
        var result = 0L;
        for (var i = 0; i < Size; i++) result += _queue.Dequeue();
        return result;
    }
}