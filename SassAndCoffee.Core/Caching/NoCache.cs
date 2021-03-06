namespace SassAndCoffee.Core.Caching
{
    using System;

    public class NoCache : ICompiledCache
    {
        public CompilationResult GetOrAdd(string filename, Func<string, CompilationResult> compilationDelegate, string mimeType)
        {
            return compilationDelegate(filename);
        }

        public void Clear()
        {
        }
    }
}