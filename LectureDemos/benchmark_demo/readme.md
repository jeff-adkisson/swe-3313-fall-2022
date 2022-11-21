# Cyclomatic Complexity, Friendly Code, and Performance, and Memory Usage Demo

Demo showing how friendly, easy to read/write code
is often not as fast as optimized, extremely fast code.
Fast is great, but sometimes readability is more important.
Also, fast code often takes much more time to write... does
it matter if it's super fast if what you have is fast enough
for the foreseeable future?

https://stackify.com/premature-optimization-evil/

Often developers focus on optimizing things that do not need
optimization. It's often difficult to determine what actually
needs to be super-fast until the first version of your
application is done and customers are using it. Therefore,
it's a good rule of thumb to be wary of "premature optimization"

Adapted from https://blog.ndepend.com/improve-c-code-performance-with-spant/
I made the code a bit more approachable, added a couple more cases

## To run:
**You must run this code in Release mode (BenchmarkDotNet requires compiler optimizations)**

`dotnet run -c Release`
or start in *Release* mode in Visual Studio

## What is the difference in debug and release mode?

http://net-informations.com/faq/net/debug-release.htm