
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_7EE99C3F9B437A61 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_7EE99C3F9B437A61 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_7EE99C3F9B437A61(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem50JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

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
                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileAttributesAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileAttributesAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionAppStoreReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionAppStoreReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionExternalBetaReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionExternalBetaReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleaseAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleaseAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsBackgroundAssetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsBackgroundAssetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAppStoreReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAppStoreReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAssetFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsAssetFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsManifestFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionRelationshipsManifestFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsInternalBetaVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsInternalBetaVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsExternalBetaVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetRelationshipsExternalBetaVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionAppStoreReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionAppStoreReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseState))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionExternalBetaReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionExternalBetaReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumsCompositeAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?))
                {
                    return new global::AppStoreConnect.JsonConverters.ChecksumsCompositeAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppMediaAssetState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppMediaAssetState(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaStateError))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaStateError(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsExternalBetaVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsExternalBetaVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsExternalBetaVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsInternalBetaVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsInternalBetaVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsInternalBetaVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetRelationshipsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFileAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFileAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetUploadFileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreRelease(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreReleaseAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreReleaseRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreReleaseState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAppStoreReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAttributesStateDetails))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAttributesStateDetails(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaRelease(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaReleaseAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaReleaseRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaReleaseState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionExternalBetaReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaRelease(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsAppStoreRelease(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsAppStoreReleaseData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsAppStoreReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsAssetFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsAssetFileData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsAssetFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsBackgroundAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsBackgroundAssetData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsBackgroundAssetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetUploadFiles))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsBackgroundAssetUploadFiles(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsExternalBetaRelease(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsExternalBetaReleaseData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsInternalBetaRelease(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsInternalBetaReleaseData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsManifestFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsManifestFileData(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionRelationshipsManifestFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFilterPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BackgroundAssetsVersionsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumAlgorithm))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.Checksums))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Checksums(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsComposite))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumsComposite(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumsCompositeAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_ChecksumsFile(options);
                }
                if (type == typeof(global::AppStoreConnect.DeliveryFileUploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_DeliveryFileUploadOperation(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem50))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem502(options);
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
                if (type == typeof(global::AppStoreConnect.Platform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Platform2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.StateDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_StateDetail(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F9B42551182B8128(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_837853212A8A77A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9D74F7C1D99FCDF1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D4EBA42987A081E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C60EAC1E875C63B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_91A9A8E9BDA00FE6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2254688CDBBE1423(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BD56561E11E4583B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_856A91EE5AEB2669(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EA3455CD1845872C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_07E856BC746F1B26(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BF2D6D544A7FBA7E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EC32B89E4148608F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EB8A560F5BCCA91F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DeliveryFileUploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_781A3B4F64735229(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem50>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D5ECB82B684BC2F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3798DE021B791640(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E0931479E69985D5(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(long))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetRelationshipsExternalBetaVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetRelationshipsInternalBetaVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetUploadFileAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetUploadFileType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetUploadFileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionAppStoreReleaseRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionAppStoreReleaseState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreReleaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionAppStoreReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionExternalBetaReleaseRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionExternalBetaReleaseState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaReleaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionExternalBetaReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionInternalBetaReleaseAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionInternalBetaReleaseRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionInternalBetaReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreReleaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionRelationshipsAppStoreReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFileDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionRelationshipsAssetFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionRelationshipsBackgroundAssetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaReleaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionRelationshipsExternalBetaReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaReleaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionRelationshipsInternalBetaReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFileDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionRelationshipsManifestFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBackgroundAssetVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFilterPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBackgroundAssetsVersionsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumAlgorithm?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableChecksumAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableChecksumsCompositeAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem50?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem502(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D62913E2425518D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAsset>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5FAE96E08545E268(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_CE5D3681DAED2852(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C0BDD5941578CFF5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionAppStoreRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_50B987C8E2C85E78(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionExternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E5E3619FE8CD47BA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFieldsBackgroundAssetVersionInternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3671CD5F5EE721F5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1D3CA71AED111FFB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F53895969254EB2F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterInternalBetaReleaseStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B7AA270382E9ED2D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterPlatform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D2DBC643ED0CA1DE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5C55E2E078D5D2C6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E749AE886CF12B72(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetsVersionsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_6DD2D85D4EE07B9C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DeliveryFileUploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F6318151BA819E6D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem50>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CF72689E4B81F34A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Platform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_6ADAD7FAA70A2CBB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.StateDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_7D7569F841DF8E53(options);
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