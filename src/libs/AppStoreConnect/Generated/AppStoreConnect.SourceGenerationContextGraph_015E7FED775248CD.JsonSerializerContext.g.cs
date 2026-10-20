
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_015E7FED775248CD : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_015E7FED775248CD Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_015E7FED775248CD(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem140JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPriceRelationshipsPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPriceRelationshipsPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPrice(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceRelationshipsPricePoint(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceRelationshipsPricePointData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceRelationshipsPricePointDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceRelationshipsTerritory(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceRelationshipsTerritoryData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPriceType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPricesResponse(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPricesResponseIncludedItemDiscriminator(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePoint(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsEqualizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsEqualizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritory(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritoryData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem140))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1402(options);
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
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.Territory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Territory(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_7EF689F2F39D464C(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_5C19EDA424314BE2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_578B52BC1329E161(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_453F73F1F69968A8(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_17A71E3EDAFB09AF(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem140>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C0EA7125D75EE6E6(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsPricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferPriceRelationshipsPricePointDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferPriceRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPriceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferPriceType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePricePointRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePricePointType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem140?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1402(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchaseOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A258B5C38491C7EA(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsInAppPurchasePricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9B9BA0DAF6D6D30B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_595E4431DF0E1E98(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodesPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C9182FAAA293B2C4(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A57096521234776F(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem140>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_734A259F81795646(options);
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