
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D406C45A066978D3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D406C45A066978D3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D406C45A066978D3(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem75JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryCode)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1AttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1AttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1RelationshipsReviewDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseV1RelationshipsReviewDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsReviewTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewRelationshipsReviewTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryCode))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceFieldsCustomerReviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceFieldsCustomerReviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceFieldsCustomerReviewResponseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceFieldsCustomerReviewResponseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CustomerReview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReview(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewRelationshipsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewRelationshipsResponseData(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewRelationshipsResponseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewRelationshipsReviewTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewRelationshipsReviewTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewRelationshipsReviewTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1Attributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1AttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1Relationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1RelationshipsReview(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1RelationshipsReviewData(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1RelationshipsReviewDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewResponseV1Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CustomerReviewsGetInstanceFieldsCustomerReview2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CustomerReviewsGetInstanceFieldsCustomerReviewResponse2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CustomerReviewsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CustomerReviewsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem75))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem752(options);
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
                if (type == typeof(global::AppStoreConnect.TerritoryCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_TerritoryCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_932C8C5ADEA67A3F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B7DD93AE8CF3323C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2FEF0F27AB93DAF4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1C21B1267F30075A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem75>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_83C5C3374F8F1FE6(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsResponseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewRelationshipsResponseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewRelationshipsReviewTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewRelationshipsReviewTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1AttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewResponseV1AttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1RelationshipsReviewDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewResponseV1RelationshipsReviewDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewResponseV1Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewResponseV1Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCustomerReviewsGetInstanceFieldsCustomerReview2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCustomerReviewsGetInstanceFieldsCustomerReviewResponse2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCustomerReviewsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCustomerReviewsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem75?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem752(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6B0D5EF6645AFB02(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FC7ADA93CAFEC66A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3675448D716BFA14(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B4A3CD801CCD1D0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem75>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_50BF31BF7C216AF1(options);
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