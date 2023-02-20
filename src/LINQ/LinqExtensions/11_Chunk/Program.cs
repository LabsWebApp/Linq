using Core;

var forChunk = Enumerable.Range(0, 10);
var chunk = forChunk.Chunk(3);

int chunkCount = 0;
foreach (var item in chunk)
{
    Console.WriteLine($"Chunk №{chunkCount++}:");
    //foreach (var val in item)
    //{
    //    Console.Write($"\t{val}");
    //}
    item.CommaWriter();
    Console.WriteLine();
}