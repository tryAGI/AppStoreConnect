
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D1F3F42B3A3C5A7B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D1F3F42B3A3C5A7B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D1F3F42B3A3C5A7B(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionAttributesStateDetails))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionAttributesStateDetails(options);
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
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BackgroundAssetVersionInternalBetaReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F9B42551182B8128(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_799C8FBB707B610A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A04B30DED824DDA9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CD752C240FE1D85B(options);
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
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D62913E2425518D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B7B645D128495527(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_617A2083435D6A55(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionInternalBetaReleasesGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1AC146D838D5DB3E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Platform>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_6ADAD7FAA70A2CBB(options);
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