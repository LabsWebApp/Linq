using BenchmarkDotNet.Attributes;
using TrivialCollections.SingleLinked;

namespace TrivialCollections.Tests;

[MemoryDiagnoser]
[RankColumn]
public class CollectionsFillBenchmark
{
    [Params(1, 100, 10_000/*, 1_000_000_000*/)]
    public int Size;

    [Benchmark(Baseline = true)]
    public void ListFillTest()
    {
        var list = new List<int>();
        for (var i = 0; i < Size; i++) list.Add(i);
    }

    [Benchmark]
    public void ArrayFillTest()
    {
        var arr = Array.Empty<int>();
        for (var i = 0; i < Size; i++)
        {
            var result = new int[arr.Length + 1];
            arr.CopyTo(result, 0);
            result[^1] = i;
            arr = result;
        }
    }

    [Benchmark]
    public void StackFillTest()
    {
        var stack = new TrivialStack<int>();
        for (var i = 0; i < Size; i++) stack.Push(i);
    }

    [Benchmark]
    public void NativeStackFillTest()
    {
        var stack = new Stack<int>();
        for (var i = 0; i < Size; i++) stack.Push(i);
    }

    [Benchmark]
    public void QueueFillTest()
    {
        var queue = new TrivialQueue<int>();
        for (var i = 0; i < Size; i++) queue.Enqueue(i);
    }

    [Benchmark]
    public void NativeQueueFillTest()
    {
        var queue = new Queue<int>();
        for (var i = 0; i < Size; i++) queue.Enqueue(i);
    }

    [Benchmark]
    public void StructStackFillTest()
    {
        var stack = new TrivialStructStack<int>();
        for (var i = 0; i <= Size; i++) stack.Push(i);
    }
}