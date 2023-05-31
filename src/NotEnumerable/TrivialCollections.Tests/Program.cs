using BenchmarkDotNet.Running;
using TrivialCollections.Tests;

BenchmarkRunner.Run<CollectionsFillBenchmark>();

Console.ReadKey();