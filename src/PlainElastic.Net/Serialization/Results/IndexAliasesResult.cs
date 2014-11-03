using System.Collections.Generic;

namespace PlainElastic.Net.Serialization
{
    public class IndexAliasesResult
    {
		public Dictionary<string, Dictionary<string, IndexAliasesResult>> Aliases { get; set; }
    }
}