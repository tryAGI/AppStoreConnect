
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "BackgroundAssetVersionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "BackgroundAssetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataType), TypeInfoPropertyName = "BackgroundAssetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "BackgroundAssetCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestDataType), TypeInfoPropertyName = "BackgroundAssetUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItemType), TypeInfoPropertyName = "BackgroundAssetVersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset), TypeInfoPropertyName = "BackgroundAssetsGetInstanceFieldsBackgroundAsset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp), TypeInfoPropertyName = "BackgroundAssetsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion), TypeInfoPropertyName = "BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem), TypeInfoPropertyName = "BackgroundAssetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFilterPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "BackgroundAssetsVersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableBackgroundAssetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataType?), TypeInfoPropertyName = "NullableBackgroundAssetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableBackgroundAssetCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestDataType?), TypeInfoPropertyName = "NullableBackgroundAssetUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableBackgroundAssetVersionsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset?), TypeInfoPropertyName = "NullableBackgroundAssetsGetInstanceFieldsBackgroundAsset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableBackgroundAssetsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion?), TypeInfoPropertyName = "NullableBackgroundAssetsGetInstanceFieldsBackgroundAssetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableBackgroundAssetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFilterPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableBackgroundAssetsVersionsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem>))]
    internal sealed partial class BackgroundAssetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundAssetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BackgroundAssetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BackgroundAssetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceFieldsBackgroundAssetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAsset?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceFieldsBackgroundAssetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceFieldsBackgroundAssetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetsVersionsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new BackgroundAssetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}