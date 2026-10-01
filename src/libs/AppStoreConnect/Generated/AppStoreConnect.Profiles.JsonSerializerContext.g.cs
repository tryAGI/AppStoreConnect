
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "ProfilesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "ProfileResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataType), TypeInfoPropertyName = "ProfileCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType), TypeInfoPropertyName = "ProfileCreateRequestDataAttributesProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType), TypeInfoPropertyName = "ProfileCreateRequestDataRelationshipsBundleIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType), TypeInfoPropertyName = "ProfileCreateRequestDataRelationshipsDevicesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType), TypeInfoPropertyName = "ProfileCreateRequestDataRelationshipsCertificatesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BundleIdWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponseDataType), TypeInfoPropertyName = "ProfileBundleIdLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CertificatesWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItemType), TypeInfoPropertyName = "ProfileCertificatesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DevicesWithoutIncludesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItemType), TypeInfoPropertyName = "ProfileDevicesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem), TypeInfoPropertyName = "ProfilesGetCollectionFilterProfileTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem), TypeInfoPropertyName = "ProfilesGetCollectionFilterProfileStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionSortItem), TypeInfoPropertyName = "ProfilesGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsProfile), TypeInfoPropertyName = "ProfilesGetCollectionFieldsProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId), TypeInfoPropertyName = "ProfilesGetCollectionFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsDevice), TypeInfoPropertyName = "ProfilesGetCollectionFieldsDevice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate), TypeInfoPropertyName = "ProfilesGetCollectionFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionIncludeItem), TypeInfoPropertyName = "ProfilesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile), TypeInfoPropertyName = "ProfilesGetInstanceFieldsProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId), TypeInfoPropertyName = "ProfilesGetInstanceFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice), TypeInfoPropertyName = "ProfilesGetInstanceFieldsDevice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate), TypeInfoPropertyName = "ProfilesGetInstanceFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem), TypeInfoPropertyName = "ProfilesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId), TypeInfoPropertyName = "ProfilesBundleIdGetToOneRelatedFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate), TypeInfoPropertyName = "ProfilesCertificatesGetToManyRelatedFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice), TypeInfoPropertyName = "ProfilesDevicesGetToManyRelatedFieldsDevice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableProfilesResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableProfileResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataType?), TypeInfoPropertyName = "NullableProfileCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType?), TypeInfoPropertyName = "NullableProfileCreateRequestDataAttributesProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType?), TypeInfoPropertyName = "NullableProfileCreateRequestDataRelationshipsBundleIdDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType?), TypeInfoPropertyName = "NullableProfileCreateRequestDataRelationshipsDevicesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType?), TypeInfoPropertyName = "NullableProfileCreateRequestDataRelationshipsCertificatesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponseDataType?), TypeInfoPropertyName = "NullableProfileBundleIdLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableProfileCertificatesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableProfileDevicesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem?), TypeInfoPropertyName = "NullableProfilesGetCollectionFilterProfileTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem?), TypeInfoPropertyName = "NullableProfilesGetCollectionFilterProfileStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionSortItem?), TypeInfoPropertyName = "NullableProfilesGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsProfile?), TypeInfoPropertyName = "NullableProfilesGetCollectionFieldsProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId?), TypeInfoPropertyName = "NullableProfilesGetCollectionFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsDevice?), TypeInfoPropertyName = "NullableProfilesGetCollectionFieldsDevice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate?), TypeInfoPropertyName = "NullableProfilesGetCollectionFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableProfilesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile?), TypeInfoPropertyName = "NullableProfilesGetInstanceFieldsProfile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId?), TypeInfoPropertyName = "NullableProfilesGetInstanceFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice?), TypeInfoPropertyName = "NullableProfilesGetInstanceFieldsDevice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate?), TypeInfoPropertyName = "NullableProfilesGetInstanceFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableProfilesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId?), TypeInfoPropertyName = "NullableProfilesBundleIdGetToOneRelatedFieldsBundleId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate?), TypeInfoPropertyName = "NullableProfilesCertificatesGetToManyRelatedFieldsCertificate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice?), TypeInfoPropertyName = "NullableProfilesDevicesGetToManyRelatedFieldsDevice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionFieldsProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionFieldsDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsDevice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice>))]
    internal sealed partial class ProfilesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfilesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProfilesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProfilesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ProfilesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsProfile)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsProfile?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsDevice)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsDevice?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate?)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice)

                    || typeToConvert == typeof(global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataAttributesProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataAttributesProfileType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataAttributesProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsBundleIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsBundleIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsBundleIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsDevicesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsDevicesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsDevicesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsCertificatesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCreateRequestDataRelationshipsCertificatesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCreateRequestDataRelationshipsCertificatesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileBundleIdLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileBundleIdLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileBundleIdLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCertificatesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileCertificatesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileCertificatesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileDevicesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfileDevicesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfileDevicesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFilterProfileTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFilterProfileTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFilterProfileStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFilterProfileStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFilterProfileStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsProfile))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsProfile?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsDevice))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsDeviceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsDevice?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsDeviceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsProfileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsProfile?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsProfileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsDeviceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsDevice?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsDeviceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesBundleIdGetToOneRelatedFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesBundleIdGetToOneRelatedFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesBundleIdGetToOneRelatedFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesCertificatesGetToManyRelatedFieldsCertificateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesCertificatesGetToManyRelatedFieldsCertificate?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesCertificatesGetToManyRelatedFieldsCertificateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesDevicesGetToManyRelatedFieldsDeviceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ProfilesDevicesGetToManyRelatedFieldsDevice?))
                {
                    return new global::AppStoreConnect.JsonConverters.ProfilesDevicesGetToManyRelatedFieldsDeviceNullableJsonConverter();
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
                    0 => new ProfilesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}