using BenchmarkDotNet.Attributes;

namespace ExpressionTree;

[MemoryDiagnoser]
[RankColumn]
public class SimpleBenchmark
{
    private const int SemiMax = int.MaxValue / 2;
    private readonly Random _random = new(DateTime.Now.Millisecond);
    private int RandomInt(int maxValue = SemiMax) => _random.Next(0, maxValue);
    private SimpleAdd<int>? _simple;

    [GlobalSetup]
    public void Setup() => _simple = new();

    [Params(10, 100, 100000)]
    public int Test;

    [Benchmark(Description = "plus")]
    public void PlusTest()
    {
        for (int i = 0; i < Test; i++)
        {
            var result = RandomInt() + RandomInt();
        }
    }

    [Benchmark(Description = "Add")]
    public void AddTest()
    {
        for (int i = 0; i < Test; i++)
        {
            var result = _simple.Add(RandomInt(), RandomInt());
        }
    }
}