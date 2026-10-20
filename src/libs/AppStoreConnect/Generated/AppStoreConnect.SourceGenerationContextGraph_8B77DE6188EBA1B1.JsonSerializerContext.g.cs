
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_8B77DE6188EBA1B1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_8B77DE6188EBA1B1 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_8B77DE6188EBA1B1(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.RelationshipsJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementImageRelationshipsJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementVideoRelationshipsJsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequestNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryMediaType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppEventLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2Image))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2Image(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2ImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment_86084021c9eafb36(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementRelationshipsDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementType22(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2Video))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2Video(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2VideoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Relationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.StateDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_StateDetail(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_463F6F8D0614F6D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4CE4ADA243CCF799(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DE584EB39CB437FC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_45E32E61D775B1AE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9D9B8AF4D7869A2F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F8FD35F39B279720(options);
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryMediaType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementImageRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatment_dbc293338efb117b(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementOrderingRequestCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementOrderingRequestType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementRelationshipsDiscriminatorMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementType22(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementVideoRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.Relationships?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableRelationships2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_8E7607241084AB92(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_401A7EF1F6666C4B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_213FBD1301251B98(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A34D78DFF5111238(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_118982E7AA3AF153(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F18A5668940D93AC(options);
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