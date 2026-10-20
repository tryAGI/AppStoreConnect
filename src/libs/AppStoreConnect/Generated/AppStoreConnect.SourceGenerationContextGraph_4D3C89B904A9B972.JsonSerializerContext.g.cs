
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4D3C89B904A9B972 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4D3C89B904A9B972 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4D3C89B904A9B972(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem63JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesUti)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesUti?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadState)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildUploadState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm)

                    || typeToConvert == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileAttributesAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileAttributesAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesUti))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileAttributesUtiJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadFileAttributesUti?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadFileAttributesUtiNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetDescriptionFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetDescriptionFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetSpiFileDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadRelationshipsAssetSpiFileDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadState))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildUploadState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildUploadStateNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.Build))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Build(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributesProcessingState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAttributesProcessingState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclarationData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmission(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmissionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundles))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundles(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundlesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundlesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUpload(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUploadData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsDiagnosticSignatures))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsDiagnosticSignatures(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIcons))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIcons(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIconsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIconsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTesters))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTesters(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTestersDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPerfPowerMetrics))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPerfPowerMetrics(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUpload(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadAttributesState(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileAttributesAssetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileAttributesUti))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileAttributesUti2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadFileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetDescriptionFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetDescriptionFileData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetDescriptionFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetFileData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetSpiFile(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetSpiFileData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsAssetSpiFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsBuild(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsBuildData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildUploadFiles))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadRelationshipsBuildUploadFiles(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildUploadType2(options);
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem63))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem632(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2D7F817FEB3B058A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8F872A0DF814C3EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5F90468B7885322A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BCC6B5F9FDB89FA7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D1D39E952A7598F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.DeliveryFileUploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_781A3B4F64735229(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem63>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_70D68823A0057CB1(options);
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
                if (type == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAttributesProcessingState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppEncryptionDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaAppReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaBuildLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildBetaDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildBundlesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsIconsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsIndividualTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsPreReleaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileAttributesAssetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadFileAttributesAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileAttributesUti?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadFileAttributesUti2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadFileType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadFileType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFileDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadRelationshipsAssetDescriptionFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetFileDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadRelationshipsAssetFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFileDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadRelationshipsAssetSpiFileDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadRelationshipsBuildDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildUploadType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildUploadType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumAlgorithm?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableChecksumAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.ChecksumsCompositeAlgorithm?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableChecksumsCompositeAlgorithm2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem63?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem632(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BE1E6F918C082922(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DECEC7A4996A17B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B3F4C1C38020CC64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7AD7BF85AB1EA6AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5057449BFE60E32E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.DeliveryFileUploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F6318151BA819E6D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem63>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F8CB0CE20D240C70(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.StateDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_7D7569F841DF8E53(options);
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