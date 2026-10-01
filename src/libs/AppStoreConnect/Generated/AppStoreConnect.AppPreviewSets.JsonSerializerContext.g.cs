
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppPreviewSetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataType), TypeInfoPropertyName = "AppPreviewSetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType), TypeInfoPropertyName = "AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType), TypeInfoPropertyName = "AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType), TypeInfoPropertyName = "AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItemType), TypeInfoPropertyName = "AppPreviewSetAppPreviewsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItemType), TypeInfoPropertyName = "AppPreviewSetAppPreviewsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet), TypeInfoPropertyName = "AppPreviewSetsGetInstanceFieldsAppPreviewSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization), TypeInfoPropertyName = "AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization), TypeInfoPropertyName = "AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization), TypeInfoPropertyName = "AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview), TypeInfoPropertyName = "AppPreviewSetsGetInstanceFieldsAppPreview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem), TypeInfoPropertyName = "AppPreviewSetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview), TypeInfoPropertyName = "AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet), TypeInfoPropertyName = "AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppPreviewSetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataType?), TypeInfoPropertyName = "NullableAppPreviewSetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType?), TypeInfoPropertyName = "NullableAppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType?), TypeInfoPropertyName = "NullableAppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?), TypeInfoPropertyName = "NullableAppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppPreviewSetAppPreviewsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableAppPreviewSetAppPreviewsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet?), TypeInfoPropertyName = "NullableAppPreviewSetsGetInstanceFieldsAppPreviewSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization?), TypeInfoPropertyName = "NullableAppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization?), TypeInfoPropertyName = "NullableAppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?), TypeInfoPropertyName = "NullableAppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview?), TypeInfoPropertyName = "NullableAppPreviewSetsGetInstanceFieldsAppPreview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppPreviewSetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview?), TypeInfoPropertyName = "NullableAppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet?), TypeInfoPropertyName = "NullableAppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem>))]
    internal sealed partial class AppPreviewSetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPreviewSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppPreviewSetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppPreviewSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetAppPreviewsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetAppPreviewsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetAppPreviewsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetAppPreviewsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetAppPreviewsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppPreviewSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppPreviewSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppPreviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceFieldsAppPreviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                    0 => new AppPreviewSetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}