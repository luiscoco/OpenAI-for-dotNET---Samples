// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    internal partial class InternalAutoChunkingStrategy : FileChunkingStrategy
    {
        public InternalAutoChunkingStrategy()
        {
            Type = "auto";
        }

        internal InternalAutoChunkingStrategy(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
