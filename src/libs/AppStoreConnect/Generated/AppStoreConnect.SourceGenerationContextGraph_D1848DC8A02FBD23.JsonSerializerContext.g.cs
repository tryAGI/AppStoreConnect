
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D1848DC8A02FBD23 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D1848DC8A02FBD23 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D1848DC8A02FBD23(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryType)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEventDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEventDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType2)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryType))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryAttributesDeliveryStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryAttributesDeliveryStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEventDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryRelationshipsEventDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEventDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryRelationshipsEventDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookEventType))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookEventType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookEventType2))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookEventType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhookEventType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhookEventType2NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDelivery))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDelivery(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryAttributesDeliveryState2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryAttributesRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryAttributesRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryAttributesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryAttributesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryCreateRequestDataRelationshipsTemplate(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplateData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryCreateRequestDataRelationshipsTemplateData(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryRelationshipsEvent(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEventData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryRelationshipsEventData(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEventDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryRelationshipsEventDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveryType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookEvent(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookEventAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookEventAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookEventType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookEventType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookEventType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookEventType22(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WebhookEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_96BF6DE190904D09(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryAttributesDeliveryState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWebhookDeliveryAttributesDeliveryState2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWebhookDeliveryCreateRequestDataRelationshipsTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWebhookDeliveryCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryRelationshipsEventDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWebhookDeliveryRelationshipsEventDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWebhookDeliveryType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookEventType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWebhookEventType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookEventType2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWebhookEventType22(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WebhookEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8B31D7AFB3908E80(options);
                }
                return null;
            }
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}