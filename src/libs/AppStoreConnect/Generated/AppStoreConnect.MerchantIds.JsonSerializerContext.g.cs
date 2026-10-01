
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdType), TypeInfoPropertyName = "MerchantIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItemType), TypeInfoPropertyName = "MerchantIdRelationshipsCertificatesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCreateRequestDataType), TypeInfoPropertyName = "MerchantIdCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdUpdateRequestDataType), TypeInfoPropertyName = "MerchantIdUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItemType), TypeInfoPropertyName = "MerchantIdCertificatesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionSortItem), TypeInfoPropertyName = "MerchantIdsGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId), TypeInfoPropertyName = "MerchantIdsGetCollectionFieldsMerchantId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate), TypeInfoPropertyName = "MerchantIdsGetCollectionFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem), TypeInfoPropertyName = "MerchantIdsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId), TypeInfoPropertyName = "MerchantIdsGetInstanceFieldsMerchantId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate), TypeInfoPropertyName = "MerchantIdsGetInstanceFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem), TypeInfoPropertyName = "MerchantIdsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem), TypeInfoPropertyName = "MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem), TypeInfoPropertyName = "MerchantIdsCertificatesGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate), TypeInfoPropertyName = "MerchantIdsCertificatesGetToManyRelatedFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId), TypeInfoPropertyName = "MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "MerchantIdsCertificatesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdType?), TypeInfoPropertyName = "NullableMerchantIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItemType?), TypeInfoPropertyName = "NullableMerchantIdRelationshipsCertificatesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCreateRequestDataType?), TypeInfoPropertyName = "NullableMerchantIdCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdUpdateRequestDataType?), TypeInfoPropertyName = "NullableMerchantIdUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableMerchantIdCertificatesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionSortItem?), TypeInfoPropertyName = "NullableMerchantIdsGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId?), TypeInfoPropertyName = "NullableMerchantIdsGetCollectionFieldsMerchantId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate?), TypeInfoPropertyName = "NullableMerchantIdsGetCollectionFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableMerchantIdsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId?), TypeInfoPropertyName = "NullableMerchantIdsGetInstanceFieldsMerchantId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate?), TypeInfoPropertyName = "NullableMerchantIdsGetInstanceFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableMerchantIdsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem?), TypeInfoPropertyName = "NullableMerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableMerchantIdsCertificatesGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate?), TypeInfoPropertyName = "NullableMerchantIdsCertificatesGetToManyRelatedFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId?), TypeInfoPropertyName = "NullableMerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableMerchantIdsCertificatesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem>))]
    internal sealed partial class MerchantIdsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MerchantIdsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MerchantIdsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MerchantIdsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
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
                    typeToConvert == typeof(global::AppStoreConnect.MerchantIdType)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdType?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId?)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdType))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdType?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdRelationshipsCertificatesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdRelationshipsCertificatesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdRelationshipsCertificatesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdCertificatesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdCertificatesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdCertificatesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionFieldsMerchantIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionFieldsMerchantIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetInstanceFieldsMerchantIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetInstanceFieldsMerchantIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetInstanceFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetInstanceFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFilterCertificateTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeId?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedFieldsPassTypeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.MerchantIdsCertificatesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.MerchantIdsCertificatesGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new MerchantIdsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}