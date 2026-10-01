
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataType), TypeInfoPropertyName = "CertificateCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantIdData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantIdDataType), TypeInfoPropertyName = "CertificateCreateRequestDataRelationshipsMerchantIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeIdData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeIdDataType), TypeInfoPropertyName = "CertificateCreateRequestDataRelationshipsPassTypeIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateUpdateRequestDataType), TypeInfoPropertyName = "CertificateUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponseDataType), TypeInfoPropertyName = "CertificatePassTypeIdLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem), TypeInfoPropertyName = "CertificatesGetCollectionFilterCertificateTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem), TypeInfoPropertyName = "CertificatesGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate), TypeInfoPropertyName = "CertificatesGetCollectionFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId), TypeInfoPropertyName = "CertificatesGetCollectionFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem), TypeInfoPropertyName = "CertificatesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate), TypeInfoPropertyName = "CertificatesGetInstanceFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId), TypeInfoPropertyName = "CertificatesGetInstanceFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetInstanceIncludeItem), TypeInfoPropertyName = "CertificatesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId), TypeInfoPropertyName = "CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate), TypeInfoPropertyName = "CertificatesPassTypeIdGetToOneRelatedFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem), TypeInfoPropertyName = "CertificatesPassTypeIdGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataType?), TypeInfoPropertyName = "NullableCertificateCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantIdDataType?), TypeInfoPropertyName = "NullableCertificateCreateRequestDataRelationshipsMerchantIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeIdDataType?), TypeInfoPropertyName = "NullableCertificateCreateRequestDataRelationshipsPassTypeIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificateUpdateRequestDataType?), TypeInfoPropertyName = "NullableCertificateUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponseDataType?), TypeInfoPropertyName = "NullableCertificatePassTypeIdLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem?), TypeInfoPropertyName = "NullableCertificatesGetCollectionFilterCertificateTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem?), TypeInfoPropertyName = "NullableCertificatesGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate?), TypeInfoPropertyName = "NullableCertificatesGetCollectionFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId?), TypeInfoPropertyName = "NullableCertificatesGetCollectionFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableCertificatesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate?), TypeInfoPropertyName = "NullableCertificatesGetInstanceFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId?), TypeInfoPropertyName = "NullableCertificatesGetInstanceFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableCertificatesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId?), TypeInfoPropertyName = "NullableCertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate?), TypeInfoPropertyName = "NullableCertificatesPassTypeIdGetToOneRelatedFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableCertificatesPassTypeIdGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem>))]
    internal sealed partial class CertificatesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CertificatesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CertificatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificateUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateCreateRequestDataRelationshipsMerchantIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateCreateRequestDataRelationshipsMerchantIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateCreateRequestDataRelationshipsPassTypeIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateCreateRequestDataRelationshipsPassTypeIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificateUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificateUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatePassTypeIdLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatePassTypeIdLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatePassTypeIdLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFilterCertificateTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFilterCertificateTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsPassTypeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionFieldsPassTypeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetInstanceFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetInstanceFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetInstanceFieldsPassTypeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetInstanceFieldsPassTypeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeId?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesPassTypeIdGetToOneRelatedFieldsPassTypeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesPassTypeIdGetToOneRelatedFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesPassTypeIdGetToOneRelatedFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesPassTypeIdGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CertificatesPassTypeIdGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CertificatesPassTypeIdGetToOneRelatedIncludeItemNullableJsonConverter();
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
                    0 => new CertificatesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}