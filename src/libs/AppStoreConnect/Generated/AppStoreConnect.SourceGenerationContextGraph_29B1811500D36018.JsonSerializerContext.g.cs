
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_29B1811500D36018 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_29B1811500D36018 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_29B1811500D36018(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType?)

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
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataRelationshipsPrices(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePoint(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceInlineCreateType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_93E801B1A63B76AE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_6A13C8DA1DB386D7(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferCreateRequestDataRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferPriceInlineCreateRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferPriceInlineCreateRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferPriceInlineCreateType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7765B487ED14A0DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOfferPriceInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F6B376A310DBABC9(options);
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