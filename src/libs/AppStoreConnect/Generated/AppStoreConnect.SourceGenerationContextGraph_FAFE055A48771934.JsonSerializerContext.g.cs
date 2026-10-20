
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_FAFE055A48771934 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_FAFE055A48771934 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_FAFE055A48771934(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType2)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhookEventType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.WebhooksDeliveriesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.PagedDocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagedDocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhookDeliveriesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WebhookDeliveriesResponse(options);
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
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WebhooksDeliveriesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WebhookDelivery>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_28D642B0614FA469(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WebhookEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_96BF6DE190904D09(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_AC93A7B959FA011E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_9BD9EA534CC0D43C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_3C442FFB89A0F7F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_083157F614E87F73(options);
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
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWebhooksDeliveriesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WebhookDelivery>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7E74ECD87FC3BB14(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WebhookEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8B31D7AFB3908E80(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_821F32F2715A8B54(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9203CB1800D262D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1BE5C4A24AD11D7B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F0F4268219496F14(options);
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