﻿namespace ExRam.Gremlinq.Samples.Shared
{
    public enum ProgrammingLanguage
    {
        CSharp = 1,
        Java = 2
    }

    public class Software : Vertex
    {
        public string? Name { get; set; }
        public ProgrammingLanguage Language { get; set; }
    }
}
