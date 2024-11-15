// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseTextContentPart : IJsonModel<InternalRealtimeResponseTextContentPart>
    {
        void IJsonModel<InternalRealtimeResponseTextContentPart>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseTextContentPart>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseTextContentPart)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (SerializedAdditionalRawData?.ContainsKey("text") != true)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(InternalTextValue);
            }
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind.ToString());
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalRealtimeResponseTextContentPart IJsonModel<InternalRealtimeResponseTextContentPart>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseTextContentPart>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeResponseTextContentPart)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeResponseTextContentPart(document.RootElement, options);
        }

        internal static InternalRealtimeResponseTextContentPart DeserializeInternalRealtimeResponseTextContentPart(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string text = default;
            ConversationContentPartKind type0 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type0 = new ConversationContentPartKind(property.Value.GetString());
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalRealtimeResponseTextContentPart(type0, serializedAdditionalRawData, type, text);
        }

        BinaryData IPersistableModel<InternalRealtimeResponseTextContentPart>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseTextContentPart>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseTextContentPart)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeResponseTextContentPart IPersistableModel<InternalRealtimeResponseTextContentPart>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeResponseTextContentPart>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalRealtimeResponseTextContentPart(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeResponseTextContentPart)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeResponseTextContentPart>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new InternalRealtimeResponseTextContentPart FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalRealtimeResponseTextContentPart(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
