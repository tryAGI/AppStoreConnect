
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_727EAD39BD517538 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_727EAD39BD517538 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_727EAD39BD517538(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPromotionIntent)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPromotionIntent?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPriority))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataAttributesPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPriority?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataAttributesPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPromotionIntent))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataAttributesPromotionIntentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPromotionIntent?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataAttributesPromotionIntentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferCreateRequestDataRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(global::AppStoreConnect.IntegerRange))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_IntegerRange(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferDuration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferMode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPlanType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPlanType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPriority))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPromotionIntent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataAttributesPromotionIntent2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataRelationshipsPrices(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataRelationshipsPricesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceInlineCreateType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_2164303FC2563B8D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOfferPriceInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_BD8669A3C3A1378C(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferDuration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferMode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPlanType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPlanType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPriority?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferCreateRequestDataAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataAttributesPromotionIntent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferCreateRequestDataAttributesPromotionIntent2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferCreateRequestDataRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferCreateRequestDataRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferPriceInlineCreateType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferCreateRequestDataRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C1841AD4515BDB46(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferPriceInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_19B65D401248D0D6(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
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