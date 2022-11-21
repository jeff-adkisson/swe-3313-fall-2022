using benchmark_demo;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

//Demo showing how friendly, easy to read/write code
//is often not as fast as optimized, extremely fast code.
//Fast is great, but sometimes readability is more important.
//Also, fast code often takes much more time to write... does
//it matter if it's super fast if what you have is fast enough
//for the foreseeable future?
//https://stackify.com/premature-optimization-evil/

//Often developers focus on optimizing things that do not need
//optimization. It's often difficult to determine what actually
//needs to be super-fast until the first version of your
//application is done and customers are using it. Therefore,
//it's a good rule of thumb to be wary of "premature optimization"

//Adapted from https://blog.ndepend.com/improve-c-code-performance-with-spant/
//Made code a bit more approachable, added a couple more cases

//TO RUN:
//must run in Release mode (BenchmarkDotNet requires compiler optimizations)
// dotnet run -c Release 
//or
// choose Release mode in Visual Studio

ShowArtifactsPath();

BenchmarkRunner.Run<Benchmarks_FourIntegers>();
ShowArtifactsPath();

//run for large string length
//BenchmarkRunner.Run<Benchmarks_100000Integers>();
//ShowArtifactsPath();

Console.WriteLine("Press a key to exit");
Console.ReadKey();

//shows where to find the output artifacts - csv, json, md files, etc. of benchmark data
void ShowArtifactsPath()
{
    Console.WriteLine();
    Console.WriteLine(new string('=', 80));
    Console.WriteLine("Output artifact location:");
    Console.WriteLine($"- {DefaultConfig.Instance.ArtifactsPath}");
    Console.WriteLine(new string('=', 80));
    Console.WriteLine();
}